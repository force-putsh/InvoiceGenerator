using InvoiceApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.Models
{
    public class CustumerModel: Customer
    {
        HttpClient httpClient = new HttpClient();
        
        public CustumerModel()
        {
            httpClient.BaseAddress = new Uri("https://localhost:44365/api/");
        }

        public async Task<List<Customer>> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            HttpResponseMessage response = await httpClient.GetAsync("customers");
            if (response.IsSuccessStatusCode)
            {
                customers = await response.Content.ReadAsAsync<List<Customer>>();
            }
            return customers;
        }

        public async Task<Customer> GetCustomer(int id)
        {
            Customer customer = new Customer();
            HttpResponseMessage response = await httpClient.GetAsync("customers/" + id);
            if (response.IsSuccessStatusCode)
            {
                customer = await response.Content.ReadAsAsync<Customer>();
            }
            return customer;
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("customers", customer);
            if (response.IsSuccessStatusCode)
            {
                customer = await response.Content.ReadAsAsync<Customer>();
            }
            return customer;
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            HttpResponseMessage response = await httpClient.PutAsJsonAsync("customers/" + customer.CustomerId, customer);
            if (response.IsSuccessStatusCode)
            {
                customer = await response.Content.ReadAsAsync<Customer>();
            }
            return customer;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            Customer customer = new Customer();
            HttpResponseMessage response = await httpClient.DeleteAsync("customers/" + id);
            if (response.IsSuccessStatusCode)
            {
                customer = await response.Content.ReadAsAsync<Customer>();
            }
            return customer;
        }
    }
}
