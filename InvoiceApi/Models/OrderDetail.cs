using System;
using System.Collections.Generic;

namespace InvoiceApi.Models
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public string Intitule { get; set; } = null!;

        public virtual Order? Order { get; set; } = null!;
    }
}
