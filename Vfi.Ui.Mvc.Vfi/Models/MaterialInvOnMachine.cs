using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MaterialInvOnMachine
    {
        public Nullable<int> MachineId { get; set; }
        public Nullable<int> MaterialInvId { get; set; }
        public double TotalQuantity { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int Id { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual MaterialInventory MaterialInventory { get; set; }
    }
}
