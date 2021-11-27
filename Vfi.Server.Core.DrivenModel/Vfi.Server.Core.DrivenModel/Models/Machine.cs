using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class Machine
    {
        public Machine()
        {
            MachineAppraisals = new List<MachineAppraisal>();
        }

        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<MachineAppraisal> MachineAppraisals { get; set; }
    }
}
