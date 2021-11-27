using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class ScrapReason
    {
        public ScrapReason()
        {
            WorkOrders = new List<WorkOrder>();
        }

        public int ScrapReasonId { get; set; }
        public string ScrapReasonName { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
