using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ToolOrder
    {
        public ToolOrder()
        {
            this.ToolDetails = new List<ToolDetail>();
        }

        public int ToolOrderId { get; set; }
        public string TransactionCode { get; set; }
        public string EoI { get; set; }
        public string CreatedUser { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public byte Status { get; set; }
        public bool IsApprove { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<ToolDetail> ToolDetails { get; set; }
    }
}
