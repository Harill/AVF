using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ErrorCauseForm
    {
        public ErrorCauseForm()
        {
            this.MachineRepairForms = new List<MachineRepairForm>();
        }

        public int ErrorCauseId { get; set; }
        public int StateId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string StateCode { get; set; }
        public virtual ICollection<MachineRepairForm> MachineRepairForms { get; set; }
    }
}
