using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class Tool
    {
        public Tool()
        {
            ToolDetails = new List<ToolDetail>();
            ToolPeriods = new List<ToolPeriod>();
        }

        public int ToolId { get; set; }
        public string ToolName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<ToolDetail> ToolDetails { get; set; }
        public virtual ICollection<ToolPeriod> ToolPeriods { get; set; }
    }
}
