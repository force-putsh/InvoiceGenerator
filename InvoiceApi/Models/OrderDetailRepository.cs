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
        
        public async Task<IEnumerable<OrderDetail>> GetOrderDetailsByOrderId(int orderId)
        {
            return await _appDbContext.OrderDetails.Where(o => o.OrderId == orderId).ToListAsync();
        }
    }
}

//private readonly AppDbContext _appDbContext;
//private readonly ShoppingCart _shoppingCart;

//public OrderDetailRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
//{
//    _appDbContext = appDbContext;
//    _shoppingCart = shoppingCart;
//}

//public void CreateOrder(Order order)
//{
//    order.OrderPlaced = DateTime.Now;

//    _appDbContext.Orders.Add(order);

//    var shoppingCartItems = _shoppingCart.ShoppingCartItems;

//    foreach (var shoppingCartItem in shoppingCartItems)
//    {
//        var orderDetail = new OrderDetail()
//        {
//            Amount = shoppingCartItem.Amount,
//            DrinkId = shoppingCartItem.Drink.DrinkId,
//            OrderId = order.OrderId,
//            Price = shoppingCartItem.Drink.Price
//        };

//        _appDbContext.OrderDetails.Add(orderDetail);
//    }

//    _appDbContext.SaveChanges();
//}
