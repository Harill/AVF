using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class PoTaxInvoiceReference
    {
        public PoTaxInvoiceReference()
        {
            this.PoTaxInvoiceReferenceDetails = new List<PoTaxInvoiceReferenceDetail>();
        }

        public int DetailId { get; set; }
        public int TaxInvoiceId { get; set; }
        public int ReferenceId { get; set; }
        public int ClassifiedId { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public string Unit { get; set; }
        public virtual PoTaxInvoice PoTaxInvoice { get; set; }
        public virtual ICollection<PoTaxInvoiceReferenceDetail> PoTaxInvoiceReferenceDetails { get; set; }
    }
}
