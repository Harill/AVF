using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ExportFormTP_KDDetail
    {
        public ExportFormTP_KDDetail()
        {
            this.InvoiceDetails = new List<InvoiceDetail>();
            this.TaxInvoiceProductDetails = new List<TaxInvoiceProductDetail>();
        }

        public int DetailId { get; set; }
        public Nullable<int> ExportId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public double Quality { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<int> BigBox { get; set; }
        public Nullable<int> SmallBox { get; set; }
        public string Note { get; set; }
        public Nullable<long> OrderDetailId { get; set; }
        public Nullable<long> TransactionDetailId { get; set; }
        public Nullable<bool> IsInvoiced { get; set; }
        public Nullable<int> ProductInvId { get; set; }
        public virtual ExportFormTP_KD ExportFormTP_KD { get; set; }
        public virtual Product Product { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
        public virtual TransactionDetail TransactionDetail { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<TaxInvoiceProductDetail> TaxInvoiceProductDetails { get; set; }
    }
}
