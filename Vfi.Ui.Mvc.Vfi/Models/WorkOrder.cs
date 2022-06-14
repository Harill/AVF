using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class WorkOrder
    {
        public WorkOrder()
        {
            this.WorkOrderRoutings = new List<WorkOrderRouting>();
        }

        public int WorkOrderId { get; set; }
        public int ProductId { get; set; }
        public int OrderQty { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string SerialNumber { get; set; }
        public byte Status { get; set; }
        public long OrderDetailId { get; set; }
        public int PlannedTime { get; set; }
        public int RunTime { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }
    }
}
