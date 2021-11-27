using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class DefectInventoryPeriod
    {
        public long PeriodId { get; set; }
        public long TransactionId { get; set; }
        public int InvId { get; set; }
        public System.DateTime PeriodDate { get; set; }
        public double EarlyQuantity { get; set; }
        public double Quantity { get; set; }
        public double LastQuantity { get; set; }
        public double Weight { get; set; }
        public virtual DefectInventory DefectInventory { get; set; }
        public virtual DefectTransaction DefectTransaction { get; set; }
    }
}
