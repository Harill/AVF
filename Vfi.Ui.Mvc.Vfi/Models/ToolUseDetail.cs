using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ToolUseDetail
    {
        public int DetailId { get; set; }
        public int UseId { get; set; }
        public int ToolInvMachineId { get; set; }
        public double Quantity { get; set; }
        public string Note { get; set; }
        public virtual ToolInvOnMachine ToolInvOnMachine { get; set; }
        public virtual ToolUse ToolUse { get; set; }
    }
}
