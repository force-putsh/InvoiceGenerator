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
    public partial class OrderForm : Form
    {
        CustomerModel customerModel;
        OrderModel orderModel;
        public OrderForm()
        {
            InitializeComponent();
            customerModel = new CustomerModel();
            List<Customer> customers = customerModel.GetCustomers();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Customer ID", typeof(string));
            dataTable.Columns.Add("Compagny Name", typeof(string));
            customers.ToList<Customer>().ForEach(x => dataTable.Rows.Add(x.CustomerId, x.CompanyName));
            cbCustomer.DataSource = dataTable;
            cbCustomer.DisplayMember = "Compagny Name";
            cbCustomer.ValueMember = "Customer ID";
            orderModel = new OrderModel();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            //add new order
            Order order = new Order();
            order.CustomerId =cbCustomer.SelectedValue.ToString();
            order.OrderDate = DateTime.Now;
            order.RequiredDate = dtpRequiredDate.Value;
            order.EmployeeId = 4;
            orderModel.AddOrder(order);
            this.Close();
            MessageBox.Show("Commande ajouter avec succè");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
