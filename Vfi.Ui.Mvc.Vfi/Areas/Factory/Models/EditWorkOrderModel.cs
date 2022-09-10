using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class EditWorkOrderModel {
        public EditWorkOrderModel() {
            List = new List<EditWorkOrderDetail>();
            Info = new WorkOrderProductionInfo();
        }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }

        public long OrderDetailId { get; set; }
        public string OrderNumber { get; set; }
        public int OrderQty { get; set; }
        public DateTime DueDate { get; set; }
        public string CustomerCode { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EndDateStr { get { return EndDate.ToString("dd/MM/yy hh:mm"); } }

        public List<int> WorkOrderIds { get; set; }
        public string Ids { get; set; }
        public string SerialNumber { get; set; }
        public double Quantity { get; set; }

        public byte Status { get; set; }
        public string StatusName { get { return MyUtilities.WorkOrder.GetText(Status); } }

        public int PlannedTime { get; set; }
        public int RunTime { get; set; }
        public int RoutingCount { get; set; }


        public int MaterialId { get; set; }
        public int MaterialInvId { get; set; }
        public int MachineId { get; set; }

        public double MaterialRequirement {
            get {
                return Info.DM > 0
                    ? MyUtilities.Function.RoundUp(Quantity / Info.DM)
                    : 0;
            }
        }

        public List<EditWorkOrderDetail> List { get; set; }
        public WorkOrderProductionInfo Info { get; set; }

    }

    public class EditWorkOrderDetail {
        public int WorkOrderId { get; set; }
        public string SerialNumber { get; set; }
        public double Quantity { get; set; }
    }
}