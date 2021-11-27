using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ToolInventoryRequirement
    {
        public int RequirementId { get; set; }
        public int ToolId { get; set; }
        public System.DateTime StartDate { get; set; }
        public double RequireQuantity { get; set; }
        public string Note { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual Tool Tool { get; set; }
    }
}
