using InvoiceApi.Models;
using InvoiceGenerator.Models;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Windows.Forms.Tools;
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
        List<Order> listOrder;
        Panel _panel;
        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice"/> class.
        /// </summary>
        /// <param name="panel"></param>
        public Invoice(Panel panel)
        {
            InitializeComponent();
            orderModel = new OrderModel();
            this._panel = panel;
            dtgvOrder.Visible = false;
            progressBar.BackMultipleColors = new Color[] { Color.Empty};
            progressBar.Location = new Point(this.Width / 2 - progressBar.Width / 2, this.Height / 2 - progressBar.Height / 2);
            panel2.Controls.Add(progressBar);
            progressBar.Visible = true;
            
        }
        
        private void Invoice_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void dtgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double Price = double.Parse(dtgvOrder.CurrentRow.Cells[4].Value.ToString().Substring(0, (dtgvOrder.CurrentRow.Cells[4].Value.ToString()).Length - 1));
            EditInvoice editInvoice = new EditInvoice(int.Parse(dtgvOrder.CurrentRow.Cells[0].Value.ToString()),this,_panel, dtgvOrder.CurrentRow.Cells[5].Value.ToString(),Price);
            
            _panel.Controls.Clear();
            _panel.Controls.Add(editInvoice);
            editInvoice.Dock = DockStyle.None;
            editInvoice.Show();
        }

        private void dtgvOrder_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #region backgroundWorker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            listOrder = orderModel.GetOrders();
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
                backgroundWorker1.ReportProgress(i);
            }
        }

        
        private  void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (dtgvOrder.Rows.Count > 1)
            {
                dtgvOrder.Rows.Clear();
                foreach (var item in listOrder)
                {
                    dtgvOrder.Rows.Add(item.OrderId, item.Customer.CompanyName, orderModel.DateFormatted(item.RequiredDate), orderModel.DateFormatted(item.OrderDate), orderModel.GetTotal(item.OrderId),item.Customer.CustomerId);
                }
            }
            else
            {
                foreach (var item in listOrder)
                {
                    dtgvOrder.Rows.Add(item.OrderId, item.Customer.CompanyName, orderModel.DateFormatted(item.RequiredDate), orderModel.DateFormatted(item.OrderDate), orderModel.GetTotal(item.OrderId), item.Customer.CustomerId);
                }
            }
            progressBar.Visible = false;
            dtgvOrder.Visible = true;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressBar.Update();
        }
        #endregion

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }
    }
}
