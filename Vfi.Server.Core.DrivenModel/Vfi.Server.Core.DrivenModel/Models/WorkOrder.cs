using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class WorkOrder
    {
        public WorkOrder()
        {
            WorkOrderRoutings = new List<WorkOrderRouting>();
        }

        public int WorkOrderId { get; set; }
        public Nullable<long> SalesOrderId { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> ScrapReasonId { get; set; }
        public int OrderQty { get; set; }
        public int StockedQty { get; set; }
        public short ScrappedQty { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ScrapReason ScrapReason { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }
    }
}
