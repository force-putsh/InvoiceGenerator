using InvoiceApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.Models
{
    internal class OrderDetailModel:OrderDetail
    {
        HttpClient httpClient = new HttpClient();
        private decimal total = 0;

        public OrderDetailModel()
        {
            httpClient.BaseAddress = new Uri("https://localhost:7199/api/");
        }
    }
}
