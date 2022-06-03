using InvoiceApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.Models
{
    internal class CustomerModel:Customer
    {
        HttpClient httpClient = new HttpClient();

        public CustomerModel()
        {
            httpClient.BaseAddress = new Uri("https://localhost:7199/api/");
        }

        public Customer GetCustomer(string id)
        {
            Customer customer = new Customer();
            var response = httpClient.GetStringAsync("customers/" + id).Result;
            customer = JsonConvert.DeserializeObject<Customer>(response);
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            var response = httpClient.GetStringAsync("customers").Result;
            customers = JsonConvert.DeserializeObject<List<Customer>>(response);
            return customers;
        }

        //filter by name
        public List<Customer> GetCustomers(string name)
        {
            List<Customer> customers = new List<Customer>();
            var response = httpClient.GetStringAsync("customers/name=" + name).Result;
            customers = JsonConvert.DeserializeObject<List<Customer>>(response);
            return customers;
        }
    }
}
