using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MaterialUseDetail
    {
        public MaterialUseDetail()
        {
            this.ImportFormSX1Detail = new List<ImportFormSX1Detail>();
        }

        public int DetailId { get; set; }
        public int UseId { get; set; }
        public int MaterialInvId { get; set; }
        public int MachineId { get; set; }
        public double Quantity2 { get; set; }
        public double Quantity { get; set; }
        public double EditQuantity { get; set; }
        public Nullable<int> BoxNumber { get; set; }
        public string Lot { get; set; }
        public double EditQuantity2 { get; set; }
        public string Note { get; set; }
        public bool IsDetroy { get; set; }
        public Nullable<int> ToMachineId { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual Machine Machine1 { get; set; }
        public virtual ICollection<ImportFormSX1Detail> ImportFormSX1Detail { get; set; }
        public virtual MaterialInventory MaterialInventory { get; set; }
        public virtual MaterialUseInShift MaterialUseInShift { get; set; }
    }
}
