using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class TaxInvoiceProduct
    {
        public long DetailId { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public int TaxInvoiceId { get; set; }
        public bool IsFinish { get; set; }
        public virtual Product Product { get; set; }
        public virtual TaxInvoice TaxInvoice { get; set; }
    }
}
