using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;
using Vfi.Ui.Mvc.Vfi.Models;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class WorkOrderRoutingModel {
        public int RoutingId { get; set; }
        [DataType("_WorkOrderRouteEditTemplate")]
        public string RoutingName { get; set; }
        public string RoutingFullName { get { return RoutingName + "-" + SerialNumber + "-" + ProductCode; } }
        public int WorkOrderId { get; set; }
        public string SerialNumber { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double ProductWeight { get; set; }
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public DateTime ScheduledStartDate { get; set; }
        public DateTime ScheduledEndDate { get; set; }
        public DateTime? LastRouteFinishDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public double ActualResourceHrs { get; set; }
        public double ActualResources { get; set; }
        public double PlannedCost { get; set; }
        public double ActualCost { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public int MaterialInvId { get; set; }
        public string MaterialInvCode { get; set; }
        public byte Status { get; set; }
        public string StatusName { get { return MyUtilities.WorkOrder.GetText(Status); } }
        public string MoreInfo { get; set; }
        [DataType("Number0Digit")]
        public double RoutingIndex { get; set; }
        public string RoutingLot { get; set; }
        public int NextRouteId { get; set; }
        public string NextRouteName { get; set; }

        public double PreviousRouteQuantity { get; set; }
        public double RequireQuantity { get; set; }
        public double WaitingApproveQuantity { get; set; }

        public double PlannedWeight { get; set; }

        public WorkOrderProductionInfo MoreInfoObject { get; set; }

        [DataType("_MaterialUseProductionNumberTemplate")]
        public double UsingQuantity { get; set; }
        [DataType("Number0Digit")]
        public double GoodQuantity { get; set; }
        [DataType("Number0Digit")]
        public double NGQuantity { get; set; }
        [DataType("Number0Digit")]
        public double DefectQuantity { get; set; }

        public double UsingWeight { get; set; }
        [DataType("Number0Digit")]
        public double GoodWeight { get; set; }
        [DataType("Number0Digit")]
        public double NGWeight { get; set; }
        [DataType("Number0Digit")]
        public double DefectWeight { get; set; }

        public ProductionFuelModel PackingInfo { get; set; }
        public double TotalQuantity { get { return GoodQuantity + NGQuantity + DefectQuantity; } }
        public double TotalWeight { get { return GoodWeight + NGWeight + DefectWeight; } }
        public double DiffQuantity { get; set; }
        public double DiffQuantityKg { get; set; }
        public double MaxQuantity { get; set; }
        public double DiffPercent { get { return MaxQuantity > 0 ? (TotalQuantity / MaxQuantity - 1) * 100 : 0; } }

        public string PrintGoodQuantity {
            get {
                return Status != (byte)MyUtilities.WorkOrder.Status.Pending
                    && Status != (byte)MyUtilities.WorkOrder.Status.Cancel
                    && GoodQuantity > 0
                ? string.Format("{0:n0}", GoodQuantity)
                : "";
            }
        }
        public string PrintNGQuantity {
            get {  
                return Status != (byte)MyUtilities.WorkOrder.Status.Pending
                    && Status != (byte)MyUtilities.WorkOrder.Status.Cancel
                    && NGQuantity > 0
                ? string.Format("{0:n0}", NGQuantity)
                : "";; }
        }
        public string PrintDefectQuantity {
            get {  
                return Status != (byte)MyUtilities.WorkOrder.Status.Pending
                    && Status != (byte)MyUtilities.WorkOrder.Status.Cancel
                    && DefectQuantity > 0
                ? string.Format("{0:n0}", DefectQuantity)
                : "";; }
        }

        public bool CanCancel { get; set; }
        public bool CanAdd { get; set; }
        public string CanAddDisplay { get { return CanAdd ? "" : "display:none"; } }
        public int ProductionLossRate { get; set; }
    }
    // damm
    public class WorkOrderRoutingInfo {
        public double NS { get; set; } // productivity
    }

    public class WorkOrderProductionInfo : WorkOrderRoutingInfo {
        public int DM { get; set; } // productionrate
        public double CDSP { get; set; } // productlength
        public double DC { get; set; } // knifecut
        public double PD { get; set; } // workpiece
    }

    public class RoutingConfiguration : WarehouseConfiguration {
        public byte Status { get; set; }
    }
}