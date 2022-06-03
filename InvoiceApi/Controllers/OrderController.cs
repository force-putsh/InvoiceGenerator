using InvoiceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceApi.Controllers
{
    [Route("api/Orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            try
            {
                return Ok(await _orderRepository.GetAllOrders());
                
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur lors de l'extraction des données");
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            try
            {
                var order = await _orderRepository.GetOrder(id);
                if (order == null)
                {
                    return NotFound("Aucune Commande trouvé avec cet id");
                }
                return Ok(order);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur lors de l'extraction des données");
                throw;
            }
        }

        //end point for the creation of an order and order detail
        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            try
            {
                if (order == null)
                {
                    return BadRequest();
                }
                var newOrder=await _orderRepository.AddOrder(order);
                return CreatedAtAction(nameof(GetOrderById), new { id = order.OrderId }, newOrder);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur lors de l'ajout de la Commande");
                throw;
            }
        }

        //end point for the update of an order and order detail
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, Order order)
        {
            try
            {
                if (id != order.OrderId)
                {
                    return BadRequest("l'identifiant ne correspond pas à la Commande");
                }
                var updatedOrder = await _orderRepository.UpdateOrder(order);
                if (updatedOrder == null)
                {
                    return NotFound("Aucune Commande trouvé avec cet id");
                }
                return Ok(updatedOrder);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur lors de la mise à jour de la Commande");
                throw;
            }
        }

        //end point for the deletion of an order and order detail
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            try
            {
                var order = await _orderRepository.GetOrder(id);
                if (order == null)
                {
                    return NotFound("Aucune Commande trouvé avec cet id");
                }
                await _orderRepository.DeleteOrder(id);
                return Ok("Commande supprimé");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur lors de la suppression de la Commande");
                throw;
            }
        }
    }
}
