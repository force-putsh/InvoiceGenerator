using InvoiceApi.Models;
using InvoiceGenerator.Models;
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
    public partial class CustomerItemUF : UserControl
    {
        CustomerModel customer = new CustomerModel();
        Customer actu;
        string customerId;
        public CustomerItemUF(string customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void CustomerItemUF_Load(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            actu = customer.GetCustomer(customerId);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Afficher les informations d'un client
            lbCompagnyName.Text = actu.CompanyName;
            lbAdresse.Text = actu.Address;
            lbCity.Text = actu.City;
            lbCountry.Text = actu.Country;
            lbPhone.Text = actu.Phone;
            lbFax.Text = actu.Fax;
            lbContactName.Text = actu.ContactName;
            lbContactTitle.Text = actu.ContactTitle;
            lbCodePostal.Text = actu.PostalCode;
            lbRegion.Text = actu.Region;
        }
    }
}
