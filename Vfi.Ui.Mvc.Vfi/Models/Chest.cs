using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Chest
    {
        public Chest()
        {
            this.ToolInvOnMachines = new List<ToolInvOnMachine>();
        }

        public int ChestId { get; set; }
        public string ChestName { get; set; }
        public string Description { get; set; }
        public bool ToolActive { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual ICollection<ToolInvOnMachine> ToolInvOnMachines { get; set; }
    }
}
