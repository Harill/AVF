using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MachineError
    {
        public MachineError()
        {
            this.Machines = new List<Machine>();
        }

        public int MachineErrorId { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Active { get; set; }
        public virtual ICollection<Machine> Machines { get; set; }
    }
}
