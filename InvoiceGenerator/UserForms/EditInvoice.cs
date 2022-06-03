using InvoiceGenerator.Models;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceGenerator.UserForms
{
    public partial class EditInvoice : UserControl
    {
        int invoiceId;
        OrderModel orderModel;
        Invoice _parent;
        Panel _panel;
        public EditInvoice(int invoiceId, Invoice parent,Panel panel)
        {
            InitializeComponent();
            this.invoiceId = invoiceId;
            orderModel = new OrderModel();
            this._parent = parent;
            this._panel = panel;
        }
        public EditInvoice()
        {
            InitializeComponent();
        }

        private void EditInvoice_Load(object sender, EventArgs e)
        {
            var invoiceDetails = orderModel.GetOrderLines(invoiceId);
            var invoice = orderModel.GetOrder(invoiceId);
            if (dtgvOD.Rows.Count > 1)
            {
                dtgvOD.Rows.Clear();
                foreach (var item in invoiceDetails)
                {
                    dtgvOD.Rows.Add(item.OrderId, item.ProductId, item.UnitPrice.ToString("C"), item.Quantity);
                }
            }
            else
            {
                foreach (var item in invoiceDetails)
                {
                    dtgvOD.Rows.Add(item.OrderId, item.ProductId, item.UnitPrice.ToString("C"), item.Quantity);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _panel.Controls.Clear();
            _panel.Controls.Add(_parent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Create new PDF document.
            PdfDocument document = new PdfDocument();

            //Add page settings.
            document.PageSettings.Margins.All = 50;
            document.PageSettings.Size = PdfPageSize.A4;
            document.PageSettings.Orientation = PdfPageOrientation.Landscape;

            //Add new page to the PDF document.
            PdfPage page = document.Pages.Add();
            PdfGraphics pdfGraphics = page.Graphics;

            //Load the image from ressources
            PdfBitmap image = new PdfBitmap(@"C:\Users\vngou\Documents\Application de stage\InvoiceGenerator\InvoiceGenerator\Images\logo.png");
            RectangleF rect = new RectangleF(176, 0, 390, 130);
            pdfGraphics.DrawImage(image, rect);

            PdfBrush solidBush = new PdfSolidBrush(new PdfColor(126, 151, 173));
            rect = new RectangleF(0, rect.Bottom + 90, page.GetClientSize().Width, 30);

            //Draw the rectangle to place the heading in page
            pdfGraphics.DrawRectangle(solidBush, rect);

            //create a font for adding the heading in page
            PdfFont headFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 20);

            //create a text element for adding the invoice number
            PdfTextElement heading = new PdfTextElement("INVOICE "+invoiceId, headFont);
            heading.Brush = PdfBrushes.White;

            //Draw the heading in page
            PdfLayoutResult result = heading.Draw(page, new PointF(10, rect.Top + 8));
            string currentDate = "DATE " + DateTime.Now.ToString("dd/MM/yyyy");

            //Measures the width of the text to place it in the correct location
            SizeF textSize = headFont.MeasureString(currentDate);
            PointF point = new PointF(pdfGraphics.ClientSize.Width - textSize.Width - 10, result.Bounds.Y);

            //Draw the date by using the DrawString method
            pdfGraphics.DrawString(currentDate, headFont, PdfBrushes.White, point);
            PdfFont timesRoman = new PdfStandardFont(PdfFontFamily.TimesRoman, 10);

            //create a text element to add the adress of the company and draw it in the page
            PdfTextElement adress = new PdfTextElement("Address: " + "123, ABC Street, XYZ City, ABC Country", timesRoman);
            adress.Brush = new PdfSolidBrush(new PdfColor(126, 155, 203));
            result = adress.Draw(page, new PointF(10, result.Bounds.Bottom + 25));
            PdfPen linePen = new PdfPen(new PdfColor(126, 155, 203),2);
            PointF startPoint = new PointF(0, result.Bounds.Bottom + 3);
            PointF endPoint = new PointF(pdfGraphics.ClientSize.Width, result.Bounds.Bottom + 3);
            pdfGraphics.DrawLine(linePen, startPoint, endPoint);

            //creating the datasource for the table
            DataTable dataTable = new DataTable();
            var data = orderModel.GetOrderLines(invoiceId);


            //Format data as currency
            dataTable.Columns.Add("Order ID", typeof(string));
            dataTable.Columns.Add("Product ID", typeof(string));
            dataTable.Columns.Add("Prix Unitaire (/8365e) ", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(string));
            //add item in data
            data.ForEach(x => dataTable.Rows.Add(x.OrderId, x.ProductId, x.UnitPrice.ToString("C"), x.Quantity));

            //creating pdf grid
            PdfGrid pdfGrid = new PdfGrid();

            //adds the data source
            pdfGrid.DataSource = dataTable;


            //create the grid cells style
            PdfGridCellStyle cellStyle = new PdfGridCellStyle();
            cellStyle.Borders.All = PdfPens.White;
            PdfGridRow headerRow = pdfGrid.Headers[0];

            //creating the header style
            PdfGridCellStyle headerStyle = new PdfGridCellStyle();
            headerStyle.Borders.All = new PdfPen(new PdfColor(126, 152, 173));
            headerStyle.BackgroundBrush = new PdfSolidBrush(new PdfColor(126, 152, 173));
            headerStyle.TextBrush = new PdfSolidBrush(new PdfColor(255, 255, 255));
            headerStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 14f, PdfFontStyle.Regular);

            //Adds cells customization
            for (int i = 0; i < headerRow.Cells.Count; i++)
            {
                headerRow.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
            }

            //apply the style to the header cells
            headerRow.ApplyStyle(headerStyle);
            cellStyle.Borders.Bottom = new PdfPen(new PdfColor(217, 217, 217), 2f);
            cellStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 12f);
            cellStyle.TextBrush = new PdfSolidBrush(new PdfColor(131, 130, 136));

            //create layout format for the grid
            PdfGridLayoutFormat layoutFormat = new PdfGridLayoutFormat();
            layoutFormat.Layout = PdfLayoutType.Paginate;

            //Draw the grid in the page
            PdfGridLayoutResult layoutResult = pdfGrid.Draw(page, new RectangleF(new PointF(0,result.Bounds.Bottom+40),new SizeF(pdfGraphics.ClientSize.Width,pdfGraphics.ClientSize.Height-100)), layoutFormat);
            


            //save pdf document

            document.Save("Invoice" + invoiceId + ".pdf");
            MessageBox.Show("Invoice" + invoiceId + ".pdf");
            //close the document
            document.Close(true);
        }
    }
}
