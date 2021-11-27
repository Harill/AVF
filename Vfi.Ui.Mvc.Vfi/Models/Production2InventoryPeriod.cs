using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Production2InventoryPeriod
    {
        public long PeriodId { get; set; }
        public long TransactionId { get; set; }
        public int InvId { get; set; }
        public System.DateTime PeriodDate { get; set; }
        public double EarlyQuantity { get; set; }
        public double Quantity { get; set; }
        public double LastQuantity { get; set; }
        public double Weight { get; set; }
        public virtual Production2Inventory Production2Inventory { get; set; }
    }
}
