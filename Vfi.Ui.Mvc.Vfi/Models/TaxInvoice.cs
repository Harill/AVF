using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class TaxInvoice
    {
        public TaxInvoice()
        {
            this.TaxInvoiceDetails = new List<TaxInvoiceDetail>();
            this.TaxInvoiceProducts = new List<TaxInvoiceProduct>();
            this.TaxInvoiceProductDetails = new List<TaxInvoiceProductDetail>();
        }

        public int Id { get; set; }
        public string TaxInvoiceList { get; set; }
        public Nullable<double> TotalAmount { get; set; }
        public string Currency { get; set; }
        public string Note { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<int> InvoiceId { get; set; }
        public Nullable<System.DateTime> SetupDate { get; set; }
        public int TaxPercent { get; set; }
        public int ExchangeRate { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<System.DateTime> FinishDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<TaxInvoiceDetail> TaxInvoiceDetails { get; set; }
        public virtual ICollection<TaxInvoiceProduct> TaxInvoiceProducts { get; set; }
        public virtual ICollection<TaxInvoiceProductDetail> TaxInvoiceProductDetails { get; set; }
    }
}
