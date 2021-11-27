using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class PoTaxInvoice
    {
        public PoTaxInvoice()
        {
            this.PoTaxInvoiceMoneys = new List<PoTaxInvoiceMoney>();
            this.PoTaxInvoiceReferences = new List<PoTaxInvoiceReference>();
        }

        public int TaxInvoiceId { get; set; }
        public string TaxInvoiceNumber { get; set; }
        public string CurrencyCode { get; set; }
        public int ExchangeRate { get; set; }
        public int ClassifiedId { get; set; }
        public int VendorId { get; set; }
        public string Note { get; set; }
        public byte Status { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int TaxPercent { get; set; }
        public System.DateTime PoDate { get; set; }
        public virtual MaterialClassified MaterialClassified { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<PoTaxInvoiceMoney> PoTaxInvoiceMoneys { get; set; }
        public virtual ICollection<PoTaxInvoiceReference> PoTaxInvoiceReferences { get; set; }
    }
}
