using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InvoiceApi.Models
{
    public partial class OrderDetail
    {
        [Display(Name = "Order Detail Id")]
        public int OrderId { get; set; }
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }
        [Display(Name = "Prix Unitaire")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "Quantity")]
        public short Quantity { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
