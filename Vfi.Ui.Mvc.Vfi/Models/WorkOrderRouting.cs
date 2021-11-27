using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class WorkOrderRouting
    {
        public int RoutingId { get; set; }
        public int WorkOrderId { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public System.DateTime ScheduledStartDate { get; set; }
        public System.DateTime ScheduledEndDate { get; set; }
        public Nullable<System.DateTime> ActualStartDate { get; set; }
        public Nullable<System.DateTime> ActualEndDate { get; set; }
        public Nullable<decimal> ActualResourceHrs { get; set; }
        public Nullable<decimal> PlannedCost { get; set; }
        public Nullable<decimal> ActualCost { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
