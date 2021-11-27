using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MaterialInventoryPeriod
    {
        public long MaterialInventoryPeriodId { get; set; }
        public long TransactionId { get; set; }
        public int MaterialId { get; set; }
        public int PeriodDay { get; set; }
        public int PeriodMonth { get; set; }
        public int PeriodYear { get; set; }
        public System.DateTime PeriodDate { get; set; }
        public double EarlyPeriodQuantity { get; set; }
        public Nullable<double> EarlyPeriodQuantityKg { get; set; }
        public double Quantity { get; set; }
        public Nullable<double> QuantityKg { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<double> Price { get; set; }
        public string UnitMeasure { get; set; }
        public double LastPeriodQuantity { get; set; }
        public Nullable<double> LastPeriodQuantityKg { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int MaterialInventoryId { get; set; }
        public Nullable<bool> IsDestroyed { get; set; }
        public virtual MaterialInventory MaterialInventory { get; set; }
        public virtual Material Material { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
