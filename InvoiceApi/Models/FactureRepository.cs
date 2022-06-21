using Microsoft.EntityFrameworkCore;

namespace InvoiceApi.Models
{
    public class FactureRepository : IFactureRepository
    {
        private readonly InnovationDBContext _context;

        public FactureRepository(InnovationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Facture>> GetFactures(int orderID)
        {
            return await _context.Factures.Where(f => f.OrderId == orderID).ToListAsync();
        }

        public async Task<Facture> GetFacture(int id)
        {
            return await _context.Factures.FindAsync(id);
        }

        public async Task<Facture> AddFacture(Facture facture)
        {
            _context.Factures.Add(facture);
            await _context.SaveChangesAsync();
            return facture;
        }
    }
}
