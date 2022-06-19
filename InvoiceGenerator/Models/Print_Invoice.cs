using InvoiceApi.Models;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.Models
{
    internal class Print_Invoice
    {
        /// <summary>
        /// Creates PDF
        /// </summary>
        public void CreatePDF(IList<OrderDetail> dataSource, Customer billInfo, double totalDue)
        {
            PdfDocument document = new PdfDocument();
            document.PageSettings.Orientation = PdfPageOrientation.Portrait;
            document.PageSettings.Margins.All = 50;
            PdfPage page = document.Pages.Add();
            PdfGraphics g = page.Graphics;
            PdfTextElement element = new PdfTextElement(@"House Innovation 
Douala, Cameroun
Carrefour lycée de Makepe
Tel: (+237)697-09-88-59/670-70-50-29");
            element.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 12);
            element.Brush = new PdfSolidBrush(new PdfColor(0, 0, 0));
            PdfLayoutResult result = element.Draw(page, new RectangleF(0, 0, page.Graphics.ClientSize.Width / 2, 200));
            Stream imgStream = new FileStream("../../../Images/HIlogo.png", FileMode.Open, FileAccess.Read);
            PdfImage img = PdfImage.FromStream(imgStream);
            page.Graphics.DrawImage(img, new RectangleF(g.ClientSize.Width - 200, result.Bounds.Y, 150, 100));
            PdfFont subHeadingFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 14);
            g.DrawRectangle(new PdfSolidBrush(new PdfColor(34, 83, 142)), new RectangleF(0, result.Bounds.Bottom + 40, g.ClientSize.Width, 30));
            element = new PdfTextElement("INVOICE " + dataSource[0].OrderId.ToString(), subHeadingFont);
            element.Brush = PdfBrushes.White;
            result = element.Draw(page, new PointF(10, result.Bounds.Bottom + 48));
            string currentDate = "DATE " + billInfo.Orders.Where(o => o.OrderId == dataSource[0].OrderId).FirstOrDefault().RequiredDate.ToString("d");
            SizeF textSize = subHeadingFont.MeasureString(currentDate);
            g.DrawString(currentDate, subHeadingFont, element.Brush, new PointF(g.ClientSize.Width - textSize.Width - 10, result.Bounds.Y));

            element = new PdfTextElement("BILL TO ", new PdfStandardFont(PdfFontFamily.TimesRoman, 12));
            element.Brush = new PdfSolidBrush(new PdfColor(34, 83, 142));
            result = element.Draw(page, new PointF(10, result.Bounds.Bottom + 25));

            g.DrawLine(new PdfPen(new PdfColor(34, 83, 142), 0.70f), new PointF(0, result.Bounds.Bottom + 3), new PointF(g.ClientSize.Width, result.Bounds.Bottom + 3));

            element = new PdfTextElement(billInfo.CompanyName, new PdfStandardFont(PdfFontFamily.TimesRoman, 11));
            element.Brush = new PdfSolidBrush(new PdfColor(0, 0, 0));
            result = element.Draw(page, new RectangleF(10, result.Bounds.Bottom + 5, g.ClientSize.Width / 2, 100));

            element = new PdfTextElement(billInfo.Address, new PdfStandardFont(PdfFontFamily.TimesRoman, 11));
            element.Brush = new PdfSolidBrush(new PdfColor(0, 0, 0));
            result = element.Draw(page, new RectangleF(10, result.Bounds.Bottom + 3, g.ClientSize.Width / 2, 100));

            PdfGrid grid = new PdfGrid();
            DataTable dataTable = new DataTable();
            
            dataTable.Columns.Add("Product Name", typeof(string));
            dataTable.Columns.Add("Prix Unitaire en Euro ", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(string));
            dataSource.ToList<OrderDetail>().ForEach(x => dataTable.Rows.Add(x.Intitule, x.UnitPrice.ToString("C"), x.Quantity));
            //grid.DataSource = ConvertToDataTable(dataSource);
            grid.DataSource = dataTable;
            PdfGridCellStyle cellStyle = new PdfGridCellStyle();
            cellStyle.Borders.All = PdfPens.White;
            PdfGridRow header = grid.Headers[0];
            grid.Headers.Add(1);

            PdfGridCellStyle headerStyle = new PdfGridCellStyle();
            headerStyle.Borders.All = new PdfPen(new PdfColor(34, 83, 142));
            headerStyle.BackgroundBrush = new PdfSolidBrush(new PdfColor(34, 83, 142));
            headerStyle.TextBrush = PdfBrushes.White;
            headerStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 12f, PdfFontStyle.Regular);

            for (int i = 0; i < header.Cells.Count; i++)
            {
                if (i == 0)
                    header.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
                else
                    header.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Right, PdfVerticalAlignment.Middle);
            }
            header.Cells[0].Value = "ITEM";
            header.Cells[1].Value = "UNIT PRICE";
            header.Cells[2].Value = "QUANTITY";
            header.ApplyStyle(headerStyle);
            grid.Columns[0].Width = 180;
            cellStyle.Borders.Bottom = new PdfPen(new PdfColor(34, 83, 142), 0.70f);
            cellStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 11f);
            cellStyle.TextBrush = new PdfSolidBrush(new PdfColor(0, 0, 0));
            foreach (PdfGridRow row in grid.Rows)
            {
                row.ApplyStyle(cellStyle);
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    PdfGridCell cell = row.Cells[i];
                    if (i == 0)
                        cell.StringFormat = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
                    else
                        cell.StringFormat = new PdfStringFormat(PdfTextAlignment.Right, PdfVerticalAlignment.Middle);

                    if (i == 1)
                    {
                        if (cell.Value.ToString().Contains("$"))
                        {
                            cell.Value = cell.Value.ToString();
                        }
                        else
                        {
                            if (cell.Value is double)
                                cell.Value = ((double)cell.Value).ToString("#,###.00", CultureInfo.InvariantCulture)+"$";
                            else
                                cell.Value = cell.Value.ToString() + "$";
                        }
                    }
                }
            }

            PdfGridLayoutFormat layoutFormat = new PdfGridLayoutFormat();
            layoutFormat.Layout = PdfLayoutType.Paginate;

            PdfGridLayoutResult gridResult = grid.Draw(page, new RectangleF(new PointF(0, result.Bounds.Bottom + 40), new SizeF(g.ClientSize.Width, g.ClientSize.Height - 100)), layoutFormat);
            float pos = 0.0f;
            for (int i = 0; i < grid.Columns.Count - 1; i++)
                pos += grid.Columns[i].Width;

            PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 12f, PdfFontStyle.Bold);
            gridResult.Page.Graphics.DrawString("TOTAL DUE", font, new PdfSolidBrush(new PdfColor(34, 83, 142)), new RectangleF(new PointF(pos, gridResult.Bounds.Bottom + 10), new SizeF(grid.Columns[1].Width - pos, 20)), new PdfStringFormat(PdfTextAlignment.Right));
            gridResult.Page.Graphics.DrawString("Thank you for your business!", new PdfStandardFont(PdfFontFamily.TimesRoman, 12), new PdfSolidBrush(new PdfColor(0, 0, 0)), new PointF(pos - 210, gridResult.Bounds.Bottom + 60));
            pos += grid.Columns[2].Width;
            gridResult.Page.Graphics.DrawString(totalDue.ToString("#,###.00", CultureInfo.CurrentCulture)+ "$", font, new PdfSolidBrush(new PdfColor(0, 0, 0)), new RectangleF(pos, gridResult.Bounds.Bottom + 10, grid.Columns[2].Width - pos, 20), new PdfStringFormat(PdfTextAlignment.Right));
            //di

            document.Save($"Invoice{dataSource[0].OrderId.ToString()}.pdf");
            document.Close(true);
            if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Launching the PDF file using the default Application.
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    Arguments = $"/c start Invoice{dataSource[0].OrderId}.pdf"
                };
                Process.Start(psi);
            }
        }
    }
}
