using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class PoTaxInvoiceReferenceDetail
    {
        public PoTaxInvoiceReferenceDetail()
        {
            this.ImportPurchaseOrderDetails = new List<ImportPurchaseOrderDetail>();
            this.TransactionFptDetails = new List<TransactionFptDetail>();
        }

        public int DetailId { get; set; }
        public int DetailReferenceId { get; set; }
        public int ReferenceId { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public string Unit { get; set; }
        public long ImportId { get; set; }
        public long ImportDetailId { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual ICollection<ImportPurchaseOrderDetail> ImportPurchaseOrderDetails { get; set; }
        public virtual PoTaxInvoiceReference PoTaxInvoiceReference { get; set; }
        public virtual ICollection<TransactionFptDetail> TransactionFptDetails { get; set; }
    }
}
