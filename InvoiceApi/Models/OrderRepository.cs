using Microsoft.EntityFrameworkCore;

namespace InvoiceApi.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly InnovationDBContext _Context;

        public OrderRepository(InnovationDBContext context)
        {
            _Context = context;
        }

        //Add Order and Order detail to the database
        public async Task<Order> AddOrder(Order order)
        {
            _Context.Orders.Add(order);
            await _Context.SaveChangesAsync();
            return order;
        }

        public async Task DeleteOrder(int id)
        {
            var order = await _Context.Orders.FindAsync(id);
            _Context.Orders.Remove(order);
            await _Context.SaveChangesAsync();
        }

        //Retrieve all orders, Customers and order details from the database
        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await _Context.Orders
                .Include(o => o.Customer)
                .Include(o => o.OrderDetails)
                .ToListAsync();
        }

        //Retrieve orders and orders details
        public async Task<Order> GetOrder(int id)
        {
            return await _Context.Orders.Include(o => o.Customer)
                .Include(o => o.OrderDetails)
                .FirstOrDefaultAsync(o => o.OrderId == id);
        }

        public async Task<Order> UpdateOrder(Order order)
        {
            var Result =  _Context.Orders.Update(order);
            await _Context.SaveChangesAsync();
            return Result.Entity;
        }
    }
}
