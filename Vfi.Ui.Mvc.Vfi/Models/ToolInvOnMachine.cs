using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ToolInvOnMachine
    {
        public ToolInvOnMachine()
        {
            this.ToolInvOnMachinePeriods = new List<ToolInvOnMachinePeriod>();
            this.ToolUseDetails = new List<ToolUseDetail>();
        }

        public int ToolInvMachineId { get; set; }
        public Nullable<int> MachineId { get; set; }
        public int ToolInvId { get; set; }
        public double TotalQuantity { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual ICollection<ToolInvOnMachinePeriod> ToolInvOnMachinePeriods { get; set; }
        public virtual ICollection<ToolUseDetail> ToolUseDetails { get; set; }
    }
}
