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
    public partial class CustomerUF : UserControl
    {
        CustomerModel customerModel;
        List<Customer> CustomerList;
        public CustomerUF()
        {
            InitializeComponent();
            customerModel = new CustomerModel();
            //set progres bar location at the senter of the screen
            progressBar.Location = new Point(this.Width / 2 - progressBar.Width / 2, this.Height / 2 - progressBar.Height / 2);

            progressBar.Visible = true;
            flowLayoutPanel1.Visible = false;
            panel3.Controls.Add(progressBar);
        }

        private void CustomerUF_Load(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = false;
            backgroundWorker1.RunWorkerAsync();
        }


        #region BackgroundWorker
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            CustomerList = customerModel.GetCustomers();
            foreach (var item in CustomerList)
            {
                CustomerItemUF customerItemUF = new CustomerItemUF(item.CustomerId);
                flowLayoutPanel1.Invoke(new MethodInvoker(delegate
                {
                    flowLayoutPanel1.Controls.Add(customerItemUF);
                }));
            }
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
                backgroundWorker.ReportProgress(i);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Visible = false;
            flowLayoutPanel1.Visible = true;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
        #endregion

        #region backgroundWorker1

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            flowLayoutPanel1.Invoke(new MethodInvoker(delegate
            {
                flowLayoutPanel1.Visible = false;
            }));
            CustomerList = customerModel.GetCustomers(txtFilter.Text);
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var item in CustomerList)
            {
                CustomerItemUF customerItemUF = new CustomerItemUF(item.CustomerId);
                customerItemUF.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                flowLayoutPanel1.Controls.Add(customerItemUF);
            }
            flowLayoutPanel1.Visible = true;
        }
        #endregion
    }
}
