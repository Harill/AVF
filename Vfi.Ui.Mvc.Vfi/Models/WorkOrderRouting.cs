using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class WorkOrderRouting
    {
        public WorkOrderRouting()
        {
            this.WorkOrderProcesses = new List<WorkOrderProcess>();
            this.WorkOrderRouting1 = new List<WorkOrderRouting>();
        }

        public int RoutingId { get; set; }
        public int WorkOrderId { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> WarehouseId { get; set; }
        public System.DateTime ScheduledStartDate { get; set; }
        public System.DateTime ScheduledEndDate { get; set; }
        public Nullable<System.DateTime> ActualStartDate { get; set; }
        public Nullable<System.DateTime> ActualEndDate { get; set; }
        public double ActualResourceHrs { get; set; }
        public double PlannedCost { get; set; }
        public double ActualCost { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<int> MachineId { get; set; }
        public Nullable<int> MaterialInvId { get; set; }
        public byte Status { get; set; }
        public string MoreInfo { get; set; }
        public string RoutingName { get; set; }
        public double RoutingIndex { get; set; }
        public Nullable<int> NextRouteId { get; set; }
        public string RoutingLot { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
        public virtual ICollection<WorkOrderProcess> WorkOrderProcesses { get; set; }
        public virtual MaterialInventory MaterialInventory { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual ICollection<WorkOrderRouting> WorkOrderRouting1 { get; set; }
        public virtual WorkOrderRouting WorkOrderRouting2 { get; set; }
    }
}
