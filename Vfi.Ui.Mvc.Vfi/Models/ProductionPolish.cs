using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionPolish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Section { get; set; }
        public double Rate { get; set; }
        public double Timing { get; set; }
        public string Rock { get; set; }
        public string Using { get; set; }
        public string Note { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int ProductId { get; set; }
        public bool Active { get; set; }
        public Nullable<int> MachineId { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual Product Product { get; set; }
    }
}
