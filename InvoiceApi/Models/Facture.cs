using System;
using System.Collections.Generic;

namespace InvoiceApi.Models
{
    public partial class Facture
    {
        public int FacturId { get; set; }
        public int OrderId { get; set; }
        public string? Intitule { get; set; }
        public double? Amout { get; set; }
        public DateTime? Date { get; set; }
        public double? TotalDue { get; set; }
        public double? Remain { get; set; }

        public virtual Order? Order { get; set; } = null!;
    }
}
