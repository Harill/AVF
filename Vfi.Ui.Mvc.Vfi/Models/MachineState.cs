using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MachineState
    {
        public MachineState()
        {
            this.Machines = new List<Machine>();
            this.MachineRepairForms = new List<MachineRepairForm>();
        }

        public int StateId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int WarrningPoint { get; set; }
        public string WarrningColor { get; set; }
        public int Timing { get; set; }
        public string StateCode { get; set; }
        public int EstimateTime { get; set; }
        public bool IsSetProduct { get; set; }
        public virtual ICollection<Machine> Machines { get; set; }
        public virtual ICollection<MachineRepairForm> MachineRepairForms { get; set; }
    }
}
