using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class DefectInventory
    {
        public DefectInventory()
        {
            this.DefectInventoryPeriods = new List<DefectInventoryPeriod>();
        }

        public int InvId { get; set; }
        public double TotalQuantity { get; set; }
        public double Weight { get; set; }
        public int DefectId { get; set; }
        public virtual ProductionDefect ProductionDefect { get; set; }
        public virtual ICollection<DefectInventoryPeriod> DefectInventoryPeriods { get; set; }
    }
}
