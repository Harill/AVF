using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ToolUse
    {
        public ToolUse()
        {
            this.ToolInvOnMachinePeriods = new List<ToolInvOnMachinePeriod>();
            this.ToolUseDetails = new List<ToolUseDetail>();
        }

        public int UseId { get; set; }
        public System.DateTime UsedDate { get; set; }
        public byte Status { get; set; }
        public string UsedCode { get; set; }
        public int Type { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string Note { get; set; }
        public string Department { get; set; }
        public virtual ICollection<ToolInvOnMachinePeriod> ToolInvOnMachinePeriods { get; set; }
        public virtual ICollection<ToolUseDetail> ToolUseDetails { get; set; }
    }
}
