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
    public partial class CustomerUF : UserControl
    {
        CustomerModel customerModel;
        public CustomerUF()
        {
            InitializeComponent();
            customerModel = new CustomerModel();
        }

        private void CustomerUF_Load(object sender, EventArgs e)
        {
            var CustomerList = customerModel.GetCustomers();

            flowLayoutPanel1.Controls.Clear();
            foreach (var item in CustomerList)
            {
                CustomerItemUF customerItemUF = new CustomerItemUF(item.CustomerId);
                customerItemUF.Anchor = (AnchorStyles.Top| AnchorStyles.Right);
                flowLayoutPanel1.Controls.Add(customerItemUF);
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var CustomerList = customerModel.GetCustomers(txtFilter.Text);
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in CustomerList)
            {
                CustomerItemUF customerItemUF = new CustomerItemUF(item.CustomerId);
                customerItemUF.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                flowLayoutPanel1.Controls.Add(customerItemUF);
            }
        }
    }
}
