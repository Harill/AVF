using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Fuel
    {
        public Fuel()
        {
            this.FuelInventories = new List<FuelInventory>();
            this.FuelInventoryPeriods = new List<FuelInventoryPeriod>();
            this.ProductionFuels = new List<ProductionFuel>();
            this.ProductionFuels1 = new List<ProductionFuel>();
        }

        public int FuelId { get; set; }
        public string FuelName { get; set; }
        public string FuelCode { get; set; }
        public string FuelDesctiption { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string FuelFullCode { get; set; }
        public string FuelDesignNo { get; set; }
        public double UnitPrice { get; set; }
        public double UnitWeight { get; set; }
        public virtual ICollection<FuelInventory> FuelInventories { get; set; }
        public virtual ICollection<FuelInventoryPeriod> FuelInventoryPeriods { get; set; }
        public virtual ICollection<ProductionFuel> ProductionFuels { get; set; }
        public virtual ICollection<ProductionFuel> ProductionFuels1 { get; set; }
    }
}
