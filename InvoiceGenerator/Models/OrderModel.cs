using InvoiceApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.Models
{
    public class OrderModel:Order
    {
        HttpClient httpClient = new HttpClient();
        List<OrderDetail> orderDetails = new List<OrderDetail>();
        private decimal total = 0;
        public OrderModel()
        {
            httpClient.BaseAddress = new Uri("https://localhost:7199/api/");
        }


        //caluler le prix total de la commande
        public decimal Total
        {
            get
            {
                foreach (var item in this.orderDetails)
                {
                    total += item.UnitPrice * item.Quantity;
                }
                return total;
            }
        }

        //formater le prix total de la commande
        public string TotalFormatted
        {
            get
            {
                return Total.ToString("C");
            }
        }

        //fonction pour formater la date de la commande
        public string DateFormatted(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }


        //obtenir les lignes de commande d'une commande
        public List<OrderDetail> GetOrderLines(int orderId)
        {
            var response = httpClient.GetStringAsync("OrderDetail/" + orderId).Result;
            var orderLines = JsonConvert.DeserializeObject<List<OrderDetail>>(response);
            return orderLines;
        }

        //fonction pour obtenir le prix total de chaque commandes
        public string GetTotal(int orderId)
        {
            orderDetails = GetOrderLines(orderId);
            return TotalFormatted;
        }

        
        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            string response = httpClient.GetStringAsync("Orders").Result;
            orders = JsonConvert.DeserializeObject<List<Order>>(response);
            return orders;
        }

        public  Order GetOrder(int id)
        {
            Order order = new Order();
            string response =  httpClient.GetStringAsync("Orders/" + id).Result;
            order = JsonConvert.DeserializeObject<Order>(response);
            return order;
        }

        public async Task<Order> AddOrder(Order order)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("Orders", order);
            if (response.IsSuccessStatusCode)
            {
                order = await response.Content.ReadAsAsync<Order>();
            }
            return order;
        }

        public async Task<Order> UpdateOrder(Order order)
        {
            HttpResponseMessage response = await httpClient.PutAsJsonAsync("Orders/" + order.OrderId, order);
            if (response.IsSuccessStatusCode)
            {
                order = await response.Content.ReadAsAsync<Order>();
            }
            return order;
        }

        public async Task<Order> DeleteOrder(int id)
        {
            Order order = new Order();
            HttpResponseMessage response = await httpClient.DeleteAsync("Orders/" + id);
            if (response.IsSuccessStatusCode)
            {
                order = await response.Content.ReadAsAsync<Order>();
            }
            return order;
        }
    }
}
