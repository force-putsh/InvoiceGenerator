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
    public partial class EditInvoice : UserControl
    {
        private int invoiceId;
        private OrderModel orderModel;
        private Invoice _parent;
        private Panel _panel;
        private Customer customer;
        private CustomerModel customerModel;
        private double total_price;
        private double montantPayer, reste;
        private int valide=0,solde=0;
        private string intitule;
        private FactureModel factureModel;
        public EditInvoice(int invoiceId, Invoice parent,Panel panel, string customerID,double total_price)
        {
            InitializeComponent();
            this.invoiceId = invoiceId;
            orderModel = new OrderModel();
            this._parent = parent;
            this._panel = panel;
            customerModel = new CustomerModel();
            customer = customerModel.GetCustomer(customerID);
            this.total_price = total_price;
            pnlChoice.Visible = false;
            factureModel = new FactureModel();
            lbOrderID.Text = invoiceId.ToString();
        }
        public EditInvoice()
        {
            InitializeComponent();
            pnlChoice.Visible = false;
            factureModel = new FactureModel();
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

        private void ckValide_CheckedChanged(object sender, EventArgs e)
        {
            pnlChoice.Visible = ckValide.Checked ?  true :  false;
            ckValide.Enabled = btnDeleteItem.Enabled = btnDelete.Enabled = ckValide.Checked ? false : true;
        }

        private void ckAccompte_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAccompte.Checked)
            {
                btnAdd.Text = "Save Bill";
                montantPayer =  total_price / 2;
                reste = total_price - montantPayer;
                lbPayer.Text = montantPayer + " €";
                lbReste.Text = reste + " €";
                valide = 1;
                intitule = "Accompte";
            }
            else
            {
                btnAdd.Text = "Add Item";
                montantPayer = 0;
                reste = total_price;
                lbPayer.Text = montantPayer + " €";
                lbReste.Text = reste + " €";
                valide = 0;
                intitule = "";
            }
        }

        private void ckSolde_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSolde.Checked)
            {
                ckAccompte.Checked = true;
                ckAccompte.Enabled = false;

                montantPayer = total_price;
                reste = 0;
                lbPayer.Text = montantPayer + " €";
                lbReste.Text = reste + " €";
                solde = 1;
                intitule = "Solde";
            }
            else
            {
                ckAccompte.Enabled = true;
                solde = 0;
                montantPayer = total_price / 2;
                reste = total_price - montantPayer;
                lbPayer.Text = montantPayer + " €";
                lbReste.Text = reste + " €";
                intitule = "Accompte";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text== "Add  Item")
            {
                Order order = orderModel.GetOrder(invoiceId);
                OrderDetailForm editInvoice = new OrderDetailForm(invoiceId, order);
                editInvoice.ShowDialog();
            }
            else
            {
                Order order = orderModel.GetOrder(invoiceId);
                order.Validate = valide;
                order.Sell = solde;
                Facture facture = new Facture();
                facture.OrderId = invoiceId;
                facture.Amout = montantPayer;
                facture.Remain = reste;
                facture.Date = DateTime.Now;
                facture.TotalDue = total_price;
                facture.Intitule = intitule+" "+order.Customer.CompanyName;
                factureModel.AddFacture(facture);
                orderModel.UpdateOrder(invoiceId,order);

            }
        }
    }
}
