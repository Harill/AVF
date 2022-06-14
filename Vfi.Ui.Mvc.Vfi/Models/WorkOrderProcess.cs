using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class WorkOrderProcess
    {
        public long ProcessId { get; set; }
        public int RoutingId { get; set; }
        public System.DateTime Date { get; set; }
        public double UsingQuantity { get; set; }
        public double GoodQuantity { get; set; }
        public double NGQuantity { get; set; }
        public double DefectQuantity { get; set; }
        public int EmployeeId { get; set; }
        public long ReferenceDetailId { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public byte Status { get; set; }
        public double UnitWeight { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual WorkOrderRouting WorkOrderRouting { get; set; }
    }
}
