using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class RealProduction
    {
        public int RealId { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> MachineId { get; set; }
        public Nullable<int> TrackUpId { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual Product Product { get; set; }
        public virtual TrackUpMachine TrackUpMachine { get; set; }
    }
}
