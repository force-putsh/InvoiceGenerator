using InvoiceApi.Models;
using InvoiceGenerator.Models;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceGenerator.UserForms
{
    public partial class EditFacture : UserControl
    {
        private int invoiceId;
        private OrderModel orderModel;
        private Invoice _parent;
        private Panel _panel;
        private Customer customer;
        private CustomerModel customerModel;
        private double total_price;
        public EditFacture(int invoiceId, Invoice parent,Panel panel, string customerID,double total_price)
        {
            InitializeComponent();
            this.invoiceId = invoiceId;
            orderModel = new OrderModel();
            this._parent = parent;
            this._panel = panel;
            customerModel = new CustomerModel();
            customer = customerModel.GetCustomer(customerID);
            this.total_price = total_price;
        }
        public EditFacture()
        {
            InitializeComponent();
        }

        private void EditInvoice_Load(object sender, EventArgs e)
        {
            var invoiceDetails = orderModel.GetOrderLines(invoiceId);
            if (dtgvOD.Rows.Count > 1)
            {
                dtgvOD.Rows.Clear();
                foreach (var item in invoiceDetails)
                {
                    dtgvOD.Rows.Add(item.Intitule, item.UnitPrice.ToString("C"), item.Quantity);
                }
            }
            else
            {
                foreach (var item in invoiceDetails)
                {
                    dtgvOD.Rows.Add(item.Intitule, item.UnitPrice.ToString("C"), item.Quantity);
                }
            }
            lbContactName.Text = customer.ContactName;
            cbCompagnyName.Enabled = false;
            cbCompagnyName.Text = customer.CompanyName;
            lbContactTitle.Text = customer.ContactTitle;
            lbCodePostal.Text = customer.PostalCode;
            lbTotalPrice.Text = total_price.ToString("C");
            lbCountry.Text = customer.Country;
            lbCity.Text = customer.City;
            lbAdresse.Text = customer.Address;
            lbPhone.Text = customer.Phone;
            lbFax.Text = customer.Fax;
            lbRegion.Text = customer.Region;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _panel.Controls.Clear();
            _panel.Controls.Add(_parent);
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            var data = orderModel.GetOrderLines(invoiceId);
            Print_Invoice print_ = new Print_Invoice();
            print_.CreatePDF(data, customer, total_price);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Order order = orderModel.GetOrder(invoiceId);
            OrderDetailForm editInvoice = new OrderDetailForm(invoiceId, order);
            editInvoice.ShowDialog();
        }
    }
}
