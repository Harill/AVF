using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class ToolDetail
    {
        public int ToolDetailId { get; set; }
        public int ToolOrderId { get; set; }
        public int ToolId { get; set; }
        public double Quantity { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual Tool Tool { get; set; }
        public virtual ToolOrder ToolOrder { get; set; }
    }
}
