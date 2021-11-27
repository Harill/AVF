using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class Transaction
    {
        public Transaction()
        {
            MaterialInventoryPeriods = new List<MaterialInventoryPeriod>();
            ProductInventoryPeriods = new List<ProductInventoryPeriod>();
            TransactionDetails = new List<TransactionDetail>();
        }

        public long TransactionId { get; set; }
        public Nullable<long> StockOrderId { get; set; }
        public Nullable<int> WarehouseIssueId { get; set; }
        public Nullable<int> WarehouseReceiptId { get; set; }
        public string TransactionCode { get; set; }
        public string EoI { get; set; }
        public bool MoP { get; set; }
        public string CreatedUser { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public byte Status { get; set; }
        public bool IsApprove { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<MaterialInventoryPeriod> MaterialInventoryPeriods { get; set; }
        public virtual ICollection<ProductInventoryPeriod> ProductInventoryPeriods { get; set; }
        public virtual StockOrder StockOrder { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Warehouse Warehouse1 { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
