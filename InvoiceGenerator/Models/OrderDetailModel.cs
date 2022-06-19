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
        public OrderDetailModel()
        {
            httpClient.BaseAddress = new Uri("https://localhost:7199/api/");
        }

        public async Task<OrderDetail> AddOrderDetailAsync(OrderDetail orderDetail)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("OrderDetail", orderDetail);
            if (response.IsSuccessStatusCode)
            {
                await response.Content.ReadAsAsync<OrderDetail>();
            }
                return orderDetail;
        }
    }
}
