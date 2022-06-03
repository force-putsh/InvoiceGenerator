using Microsoft.EntityFrameworkCore;

namespace InvoiceApi.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly InnovationDBContext _context;

        public CustomerRepository(InnovationDBContext context)
        {
            _context = context;
        }
        
        //ajouter un nouveau client
        public async Task<Customer> AddCustomer(Customer customer)
        {
            var Result=await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return Result.Entity;
        }

        //supprimer un client
        public async Task DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer!=null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Customer>> FilterCustomersByName(string name)
        {
            return await _context.Customers.Where(c => c.CompanyName.Contains(name)).ToListAsync();
        }

        //Recupere tous les clients
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        //Recupere un client par son id
        public async Task<Customer> GetCustomer(string id)
        {
            return await _context.Customers.FindAsync(id);
        }

        //Mise a jour d'un client
        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            var Result = _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
            return Result.Entity;
        }
    }
}
