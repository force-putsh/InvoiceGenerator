using InvoiceApi.Models;
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
    public partial class Invoice : UserControl
    {
        OrderModel orderModel;
        Panel _panel;
        public Invoice(Panel panel)
        {
            InitializeComponent();
            orderModel = new OrderModel();
            this._panel = panel;
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            var listOrder = orderModel.GetOrders();
            
            if (dtgvOrder.Rows.Count > 1)
            {
                dtgvOrder.Rows.Clear();
                foreach (var item in listOrder)
                {
                    dtgvOrder.Rows.Add(item.OrderId,item.Customer.CompanyName,orderModel.DateFormatted(item.RequiredDate), orderModel.DateFormatted(item.OrderDate), orderModel.GetTotal(item.OrderId));
                }
            }
            else
            {
                foreach (var item in listOrder)
                {
                    dtgvOrder.Rows.Add(item.OrderId, item.Customer.CompanyName, orderModel.DateFormatted(item.RequiredDate), orderModel.DateFormatted(item.OrderDate), orderModel.GetTotal(item.OrderId));
                }
            }
        }

        private void dtgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditInvoice editInvoice = new EditInvoice(int.Parse(dtgvOrder.CurrentRow.Cells[0].Value.ToString()),this,_panel);
            _panel.Controls.Clear();
            _panel.Controls.Add(editInvoice);
            editInvoice.Show();
        }

        private void dtgvOrder_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
