using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ToolInventoryPeriod
    {
        public int PeriodId { get; set; }
        public int ToolInvId { get; set; }
        public int ToolId { get; set; }
        public long TransactionId { get; set; }
        public double EarlyQuantity { get; set; }
        public double Quantity { get; set; }
        public double LastQuantity { get; set; }
        public System.DateTime PeriodDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual Tool Tool { get; set; }
        public virtual ToolInventory ToolInventory { get; set; }
        public virtual TransactionFpt TransactionFpt { get; set; }
    }
}
