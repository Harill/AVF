using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string UsingQuantityStr { get; set; }
        [DataType("Number0Digit")]
        public double GoodQuantity { get; set; }
        public double GoodWeight { get; set; }
        [DataType("Number0Digit")]
        public double NGQuantity { get; set; }
        public double NGWeight { get; set; }
        [DataType("Number0Digit")]
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
        public string ProductCode { get; set; }
        public string WorkOrderSerial { get; set; }

        public string Info { get; set; }
        public double TotalQuantity { get { return GoodQuantity + NGQuantity + DefectQuantity; } }
        public double TotalWeight { get { return GoodWeight + NGWeight + DefectWeight; } }
        public double DiffQuantity { get; set; }
        public double MaxQuantity { get; set; }
        public double DiffPercent { get { return MaxQuantity > 0 ? (TotalQuantity / MaxQuantity - 1) * 100 : 0; } }
    }
}