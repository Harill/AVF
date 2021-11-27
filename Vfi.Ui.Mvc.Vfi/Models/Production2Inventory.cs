using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Production2Inventory
    {
        public Production2Inventory()
        {
            this.Production2InventoryPeriod = new List<Production2InventoryPeriod>();
        }

        public int InvId { get; set; }
        public double TotalQuantity { get; set; }
        public double Weight { get; set; }
        public Nullable<int> ProductionSectionId { get; set; }
        public virtual ProductionSection ProductionSection { get; set; }
        public virtual ICollection<Production2InventoryPeriod> Production2InventoryPeriod { get; set; }
    }
}
