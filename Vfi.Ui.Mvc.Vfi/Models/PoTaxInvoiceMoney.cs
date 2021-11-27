using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class PoTaxInvoiceMoney
    {
        public int DetailId { get; set; }
        public int TaxInvoiceId { get; set; }
        public double Money { get; set; }
        public int Times { get; set; }
        public byte Status { get; set; }
        public System.DateTime ImportDate { get; set; }
        public string Note { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual PoTaxInvoice PoTaxInvoice { get; set; }
    }
}
