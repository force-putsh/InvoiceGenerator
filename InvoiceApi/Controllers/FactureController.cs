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
        public async Task<IActionResult> GetFactures(int id)
        {
            var facture = await _factureRepository.GetFactures(id);

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

        [HttpPut("{id}")]
        public async Task<ActionResult<Facture>> UpdateFacture(string id, Facture facture)
        {
            if (id != facture.Intitule)
            {
                return BadRequest();
            }

            return Ok(await _factureRepository.UpdateFacture(facture));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFacture(int id)
        {
            var facture = await _factureRepository.GetFacture(id);
            try
            {
                if (facture == null)
                {
                    return NotFound();
                }
                await _factureRepository.DeleteFacture(id);
                return Ok("Facture deleted");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur lors de la suppression de la Facture");
                throw;
            }
        }
    }
}
