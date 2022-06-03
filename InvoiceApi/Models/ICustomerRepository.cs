namespace InvoiceApi.Models
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<IEnumerable<Customer>> FilterCustomersByName(string name);
        Task<Customer> GetCustomer(string id);
        Task<Customer> AddCustomer(Customer customer);
        Task<Customer> UpdateCustomer(Customer customer);
        Task DeleteCustomer(int id);
        
    }
}
