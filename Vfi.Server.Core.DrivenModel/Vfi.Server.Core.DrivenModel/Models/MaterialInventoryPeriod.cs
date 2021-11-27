using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class MaterialInventoryPeriod
    {
        public long MaterialInventoryPeriodId { get; set; }
        public long TransactionId { get; set; }
        public int WarehouseId { get; set; }
        public int MaterialId { get; set; }
        public Nullable<int> PeriodDay { get; set; }
        public Nullable<int> PeriodMonth { get; set; }
        public Nullable<int> PeriodYear { get; set; }
        public Nullable<System.DateTime> PeriodDate { get; set; }
        public Nullable<double> EarlyPeriodQuantity { get; set; }
        public Nullable<double> EarlyPeriodQuantityKg { get; set; }
        public Nullable<double> EarlyPeriodPrice { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> QuantityKg { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<double> Price { get; set; }
        public string UnitMeasure { get; set; }
        public Nullable<double> LastPeriodQuantity { get; set; }
        public Nullable<double> LastPeriodQuantityKg { get; set; }
        public Nullable<double> LastPeriodPrice { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Material Material { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
