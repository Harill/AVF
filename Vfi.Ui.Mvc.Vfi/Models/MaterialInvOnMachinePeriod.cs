using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MaterialInvOnMachinePeriod
    {
        public Nullable<int> MachineId { get; set; }
        public Nullable<int> MaterialInvId { get; set; }
        public double EarlyQuantity { get; set; }
        public double Quantity { get; set; }
        public double LastQuantity { get; set; }
        public string Note { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int PeriodId { get; set; }
        public System.DateTime PeriodDate { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual MaterialInventory MaterialInventory { get; set; }
    }
}
