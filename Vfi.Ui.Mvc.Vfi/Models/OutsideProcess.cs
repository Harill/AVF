using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class OutsideProcess
    {
        public OutsideProcess()
        {
            this.ProductionPlatings = new List<ProductionPlating>();
        }

        public int ProcessId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual ICollection<ProductionPlating> ProductionPlatings { get; set; }
    }
}
