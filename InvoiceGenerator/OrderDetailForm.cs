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

namespace InvoiceGenerator
{
    public partial class OrderDetailForm : Form
    {
        int _orderID;
        OrderDetailModel orderDetailModel;
        Order _order;
        public OrderDetailForm(int orderID,Order order)
        {
            InitializeComponent();
            _orderID = orderID;
            orderDetailModel = new OrderDetailModel();
            this._order = order;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.OrderId = _orderID;
            orderDetail.Intitule = tbIntitule.Text;
            orderDetail.UnitPrice = Convert.ToDecimal(tbAmount.Text);
            orderDetail.Quantity = short.Parse(tbQuantity.Text);
            orderDetailModel.AddOrderDetailAsync(orderDetail);
            MessageBox.Show("Order detail OK");
            this.Close();

        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAmount.Text))
            {
                tbTotal.Text = (double.Parse(tbAmount.Text) * double.Parse(tbQuantity.Value.ToString())).ToString();
            }
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar!=(char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
