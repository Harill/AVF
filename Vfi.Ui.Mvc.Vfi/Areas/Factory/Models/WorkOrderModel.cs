using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class WorkOrderModel {
        public int WorkOrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public long OrderDetailId { get; set; }
        public string OrderNumber { get; set; }

        public int OrderQty { get; set; }
        public DateTime StartDate { get; set; }
        [DataType("_DateTemplateNullable")]
        public DateTime? EndDate { get; set; }
        public DateTime DueDate { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string SerialNumber { get; set; }
        public byte Status { get; set; }
        public string StatusName { get { return MyUtilities.WorkOrder.GetText(Status); } }
        public int PlannedTime { get; set; }
        public int RunTime { get; set; }
        public int RoutingCount { get; set; }


        public bool CanChoose { get; set; }
        public bool CanCancel { get; set; }
        public string RoutingName { get; set; }
        public double GoodQuantity { get; set; }
        public double NGQuantity { get; set; }
        public double DefectQuantity { get; set; }

        public string CustomerCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialLot { get; set; }
        public string StartDateStr { get { return StartDate.ToString("dd/MM/yy HH:mm"); } }
        public string EndDateStr { get { return EndDate != null ? EndDate.Value.ToString("dd/MM/yy HH:mm") : ""; } }
        public List<WorkOrderRoutingModel> Routings { get; set; }
    }

}