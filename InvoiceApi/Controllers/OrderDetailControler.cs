using InvoiceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceApi.Controllers
{
    [Route("api/OrderDetail")]
    [ApiController]
    public class OrderDetailControler : ControllerBase
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailControler(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        //Get OrderDetail by OrderId
        [HttpGet("{orderId}", Name = "GetOrderDetailByOrderId")]
        public async Task<IActionResult> GetOrderDetailByOrderId(int orderId)
        {
            var orderDetail = await _orderDetailRepository.GetOrderDetailsByOrderId(orderId);
            if (orderDetail == null)
            {
                return NotFound();
            }
            return Ok(orderDetail);
        }

        //Post OrderDetail
        [HttpPost]
        public async Task<IActionResult> AddOrderDetail([FromBody] OrderDetail orderDetail)
        {
            try
            {
                
                var response = await _orderDetailRepository.AddOrderDetail(orderDetail);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erreur lors de l'ajout de la Commande {ex.Message}");
                throw;
            }
        }


    }
}
