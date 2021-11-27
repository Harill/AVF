using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MaterialUseFormDetail
    {
        public int DetailId { get; set; }
        public Nullable<int> FormId { get; set; }
        public Nullable<int> MaterialInvId { get; set; }
        public Nullable<int> MachineId { get; set; }
        public Nullable<double> EarlyQuantity { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> EditQuantity { get; set; }
        public Nullable<double> PendingQuantity { get; set; }
        public Nullable<int> BoxNumber { get; set; }
        public string LotName { get; set; }
        public string Note { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual MaterialInventory MaterialInventory { get; set; }
        public virtual MaterialUseInShiftForm MaterialUseInShiftForm { get; set; }
    }
}
