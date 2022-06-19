using Microsoft.EntityFrameworkCore;

namespace InvoiceApi.Models
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly InnovationDBContext _appDbContext;

        public OrderDetailRepository(InnovationDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // Get all OrderDetails and product
        public async Task<IEnumerable<OrderDetail>> GetOrderDetailsByOrderId(int orderId)
        {
            return await _appDbContext.OrderDetails
                .Where(od => od.OrderId == orderId)
                .ToListAsync();
        }

        //Add OrderDetail
        public async Task<OrderDetail> AddOrderDetail(OrderDetail orderDetail)
        {
            var response = await _appDbContext.OrderDetails.AddAsync(orderDetail);
            await _appDbContext.SaveChangesAsync();
            return response.Entity;
        }
    }
}
