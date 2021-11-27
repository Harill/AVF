using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SmartProduction
    {
        public Nullable<int> MachineId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> MaterialInvId { get; set; }
        public Nullable<int> WarehouseId { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int SmartId { get; set; }
        public Nullable<int> ProductionRate { get; set; }
        public Nullable<int> FuelInvId { get; set; }
        public Nullable<int> ToolInvId { get; set; }
        public Nullable<int> ProductInvId { get; set; }
        public string UnitMeasure { get; set; }
        public Nullable<int> BoxWeight { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual MaterialInventory MaterialInventory { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductInventory ProductInventory { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
