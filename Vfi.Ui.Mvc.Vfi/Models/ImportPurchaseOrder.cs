using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ImportPurchaseOrder
    {
        public ImportPurchaseOrder()
        {
            this.ImportPurchaseOrderDetails = new List<ImportPurchaseOrderDetail>();
        }

        public long ImportId { get; set; }
        public long TransactionId { get; set; }
        public System.DateTime ImportDate { get; set; }
        public Nullable<long> PurchaseOrderId { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public double ExchangeRate { get; set; }
        public byte PurchasingSignature { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual ICollection<ImportPurchaseOrderDetail> ImportPurchaseOrderDetails { get; set; }
    }
}
