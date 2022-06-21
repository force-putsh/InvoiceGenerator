namespace InvoiceApi.Models
{
    public interface IFactureRepository
    {
        Task<IEnumerable<Facture>> GetFactures(int orderID);
        Task<Facture> GetFacture(int id);
        Task<Facture> AddFacture(Facture facture);
    }
}
