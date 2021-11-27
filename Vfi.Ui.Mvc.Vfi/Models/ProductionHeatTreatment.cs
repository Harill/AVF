using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionHeatTreatment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Section { get; set; }
        public double Rate { get; set; }
        public double Timing { get; set; }
        public string Note { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int ProductId { get; set; }
        public double Temperature { get; set; }
        public double Stiffness { get; set; }
        public bool Active { get; set; }
        public Nullable<int> MachineId { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual Product Product { get; set; }
    }
}
