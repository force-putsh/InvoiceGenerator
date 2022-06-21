using InvoiceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceApi.Controllers
{
    [Route("api/Facture")]
    [ApiController]
    public class FactureController : ControllerBase
    {
        private readonly IFactureRepository _factureRepository;

        public FactureController(IFactureRepository factureRepository)
        {
            _factureRepository = factureRepository;
        }

        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetFactures(int orderId)
        {
            var facture = await _factureRepository.GetFactures(orderId);

            if (facture == null)
            {
                return NotFound();
            }

            return Ok(facture);
        }

        [HttpPost]
        public async Task<ActionResult<Facture>> AddFacture(Facture facture)
        {
            return Ok(await _factureRepository.AddFacture(facture));
        }
    }
}
