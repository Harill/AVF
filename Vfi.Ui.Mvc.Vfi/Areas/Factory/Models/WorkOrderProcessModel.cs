using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class WorkOrderProcessModel {
        public long ProcessId { get; set; }
        public int RoutingId { get; set; }
        public DateTime Date { get; set; }
        public double UnitWeight { get; set; }
        public double UsingQuantity { get; set; }
        public double GoodQuantity { get; set; }
        public double GoodWeight { get; set; }
        public double NGQuantity { get; set; }
        public double NGWeight { get; set; }
        public double DefectQuantity { get; set; }
        public double DefectWeight { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public long ReferenceDetailId { get; set; }
        public string ModifiedUser { get; set; }
        public byte Status { get; set; }
        public string StatusName { get { return MyUtilities.WorkOrder.GetText(Status); } }
        public DateTime ModifiedDate { get; set; }

        public int Shift { get; set; }
        public string MachineName { get; set; }
        public string MaterialInvCode { get; set; }
    }
}