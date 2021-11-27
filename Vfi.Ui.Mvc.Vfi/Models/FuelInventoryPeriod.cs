using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class FuelInventoryPeriod
    {
        public int PeriodId { get; set; }
        public int FuelInvId { get; set; }
        public int FuelId { get; set; }
        public long TransactionId { get; set; }
        public double EarlyQuantity { get; set; }
        public double Quantity { get; set; }
        public double LastQuantity { get; set; }
        public System.DateTime PeriodDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual Fuel Fuel { get; set; }
        public virtual FuelInventory FuelInventory { get; set; }
        public virtual TransactionFpt TransactionFpt { get; set; }
    }
}
