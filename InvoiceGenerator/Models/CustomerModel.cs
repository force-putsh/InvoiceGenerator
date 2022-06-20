using InvoiceApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.Models
{
    public class CustomerModel: Customer
    {
        HttpClient httpClient = new HttpClient();

        public CustomerModel()
        {
            httpClient.BaseAddress = new Uri("https://localhost:44365/api/");
        }

        public Customer GetCustomer(string id)
        {
            Customer customer = new Customer();
            var response = httpClient.GetStringAsync("customers/" + id).Result;
            if (response != null)
            {
                customer = JsonConvert.DeserializeObject<Customer>(response);
            }
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            var response = httpClient.GetStringAsync("customers").Result;
            var customers = JsonConvert.DeserializeObject<List<Customer>>(response);
            return customers;
        }

        //filter by name
        public List<Customer> GetCustomers(string name)
        {
            var response = httpClient.GetStringAsync("customers/name=" + name).Result;
            var customers = JsonConvert.DeserializeObject<List<Customer>>(response);
            return customers;
        }

        public Customer GetCustomer(int id)
        {
            Customer customer = new Customer();
            var response = httpClient.GetStringAsync("customers/" + id).Result;
            if (response!=null)
            {
                customer = JsonConvert.DeserializeObject<Customer>(response);
            }
            return customer;
        }

        public Customer AddCustomer(Customer customer)
        {
            var response = httpClient.PostAsJsonAsync("customers", customer).Result;
            return response.Content.ReadAsAsync<Customer>().Result;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var response = httpClient.PutAsJsonAsync("customers/" + customer.CustomerId, customer).Result;
            return response.Content.ReadAsAsync<Customer>().Result;
        }

        public void DeleteCustomer(int id)
        {
            var response = httpClient.DeleteAsync("customers/" + id).Result;
        }      
    }
}
