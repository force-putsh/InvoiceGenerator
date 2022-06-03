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
        string customerId;
        public CustomerItemUF(string customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void CustomerItemUF_Load(object sender, EventArgs e)
        {
            //Afficher les informations d'un client
            var actu = customer.GetCustomer(customerId);
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
