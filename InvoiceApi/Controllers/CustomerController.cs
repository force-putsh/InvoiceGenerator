using InvoiceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceApi.Controllers
{
    [Route("api/Customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            try
            {
                var customers =await customerRepository.GetAllCustomers();
                return Ok(customers);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        //filtrer par nom
        [HttpGet("name={name}")]
        public async Task<IActionResult> GetCustomerByName(string name)
        {
            try
            {
                var customers = await customerRepository.FilterCustomersByName(name);
                return Ok(customers);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(string id)
        {
            try
            {
                var customer =await customerRepository.GetCustomer(id);
                if (customer == null)
                {
                    return NotFound();
                }
                return Ok(customer);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        //ajouter un client

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(Customer customer)
        {
            try
            {
                if (customer == null)
                {
                    return BadRequest();
                }
                var newCustomer = await customerRepository.AddCustomer(customer);
                return CreatedAtAction(nameof(GetCustomer), new { id = customer.CustomerId }, newCustomer);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur lors de l'ajout de la Commande");
                throw;
            }
        }

        //modifier un Client

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(string id, Customer customer)
        {
            try
            {
                if (id != customer.CustomerId)
                {
                    return BadRequest("l'identifiant ne correspond pas au clients");
                }
                var updatedCusomer = await customerRepository.UpdateCustomer(customer);
                if (updatedCusomer == null)
                {
                    return NotFound("Aucun Client trouvé avec cet id");
                }
                return Ok(updatedCusomer);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur lors de la mise à jour de la Commande");
                throw;
            }
        }
    }
}
