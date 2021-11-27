using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class StockOrder
    {
        public StockOrder()
        {
            this.Transactions = new List<Transaction>();
        }

        public long StockOrderId { get; set; }
        public Nullable<int> WarehouseIssueId { get; set; }
        public Nullable<int> WarehouseReceiptId { get; set; }
        public int StockOrderTypeId { get; set; }
        public string StockOrderCode { get; set; }
        public string EoI { get; set; }
        public bool MoP { get; set; }
        public string CreatedUser { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public byte Status { get; set; }
        public bool IsApprove { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Warehouse Warehouse1 { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
