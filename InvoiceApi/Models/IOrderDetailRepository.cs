namespace InvoiceApi.Models
{
    public interface IOrderDetailRepository
    {
        //Get OrderDetail by OrderId
        Task<IEnumerable<OrderDetail>> GetOrderDetailsByOrderId(int orderId);
    }
}
