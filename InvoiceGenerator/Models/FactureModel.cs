using InvoiceApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.Models
{
    internal class FactureModel:Facture
    {
        HttpClient httpClient = new HttpClient();

        public FactureModel()
        {
            httpClient.BaseAddress = new Uri("https://localhost:44365/api/");
        }

        //Get Factures by OrderId
        public  IList<Facture> GetFacturesByOrderId(int orderId)
        {
            var response = httpClient.GetStringAsync("Facture/" + orderId);
            var factures = JsonConvert.DeserializeObject<IList<Facture>>(response.Result);
            return factures;
        }

        //Get Facture by Id
        public Facture GetFactureById(int id)
        {
            var response = httpClient.GetStringAsync("Facture/" + id);
            var facture = JsonConvert.DeserializeObject<Facture>(response.Result);
            return facture;
        }

        //Add Facture
        public async Task<Facture>AddFacture(Facture facture)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("Facture", facture);
            if (response.IsSuccessStatusCode)
            {
                facture = await response.Content.ReadAsAsync<Facture>();
            }
            return facture;
        }

        //Update Facture
        public async Task<Facture> UpdateFacture(Facture facture)
        {
            HttpResponseMessage response = await httpClient.PutAsJsonAsync("Facture/" + facture.Intitule, facture);
            if (response.IsSuccessStatusCode)
            {
                facture = await response.Content.ReadAsAsync<Facture>();
            }
            return facture;
        }
    }
}
