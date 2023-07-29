using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class DeliverySalesReportModel {
        public DeliverySalesReportModel() {
            Details = new List<DeliverySalesReportDetailModel>();
            Productions = new List<ProductionSalesReportDetailModel>();
        }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        public string ProductNumber { get; set; }
        public string ProductCode { get; set; }

        public long OrderDetailId { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerPO { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueDate { get; set; }

        public double OrderQuantity { get; set; }
        public double TotalInv { get; set; }
        public double FinishInv { get; set; }

        public double Deliveried { get; set; }
        public double Remaining { get { return OrderQuantity - Deliveried; } }

        public DateTime? LastShippedDate { get; set; }
        public double ShippingQuantity { get; set; }
        public string ShipMethod { get; set; }

        public string OnShipNote { get; set; }

        public DateTime? LastProductionDate { get; set; }
        public double ProductionQuantity { get; set; }
        public string LastProductionNote { get; set; }

        public int Status { get; set; }
        public string StatusName { get { return DeliverySalesReportStatus.CastText(Status); } }
        public string StatusColor { get; set; }
        public void OverideStatus(int newStatus, string statusColor) {
            if (Status > newStatus) return;
            Status = newStatus;
            StatusColor = statusColor;
        }
        public List<DeliverySalesReportDetailModel> Details { get; set; }
        public List<ProductionSalesReportDetailModel> Productions { get; set; }
    }

    public class DeliverySalesReportDetailModel {
        public double Quantity { get; set; }
        public DateTime Date { get; set; }
        public string Method { get; set; }
    }
    public class ProductionSalesReportDetailModel {
        public double Quantity { get; set; }
        public int Status { get; set; }
        public DateTime Date { get; set; }
        public string Machine { get; set; }
    }

    public class ProductDeliverySalesReportModel {
        public ProductDeliverySalesReportModel() {
            List = new List<DeliverySalesReportModel>();
            Productions = new List<ProductionSalesReportDetailModel>();
        }
        public string CustomerCode { get; set; }
        public string ProductNumber { get; set; }
        public string ProductCode { get; set; }
        public double TotalInv { get; set; }
        public double FinishInv { get; set; }
        public DateTime ReportDate { get; set; }

        public double OrderQuantity { get { return List.Sum(x => x.OrderQuantity); } }
        public double Deliveried { get { return List.Sum(x => x.Deliveried); } }
        public double Remaining { get { return OrderQuantity - Deliveried; } }

        public double ShippingQuantity { get { return List.Sum(x => x.ShippingQuantity); } }
        public double ProductionQuantity { get { return Productions.Sum(x => x.Quantity); } }
        public int ProductionStatus { get; set; }
        public string StatusName { get { return DeliverySalesReportStatus.CastText(ProductionStatus); } }

        public List<DeliverySalesReportModel> List { get; set; }
        public List<ProductionSalesReportDetailModel> Productions { get; set; }
        public int ListCount { get { return List.Count; } }
        public int RunningCount { get { return List.Count(x => x.Status == (byte)DeliverySalesReportStatus.Running); } }
        public int SetupCount { get { return List.Count(x => x.Status == (byte)DeliverySalesReportStatus.Setup); } }
        public int ProblemCount { get { return List.Count(x => x.Status == (byte)DeliverySalesReportStatus.Problem); } }
        public int CompletedCount { get { return List.Count(x => x.Status == (byte)DeliverySalesReportStatus.Completed); } }
        public int WaitingCount { get { return List.Count(x => x.Status == (byte)DeliverySalesReportStatus.Waiting); } }
    }

    public static class DeliverySalesReportStatus {
        public static int Waiting = 0; // FFFFFF
        public static int Running = 1; // 66CC00 -> 102, 204, 0
        public static int Setup = 2; // 3399FF -> 51, 153, 255
        public static int Problem = 4; // FF2929 -> 255, 41, 41
        public static int Completed = 5; // FFDF00 -> 255, 223, 0
        public static string CastText(int status) {
            switch (status) {
                case 0:
                    return "Waiting for available machine";
                case 1:
                    return "Running";
                case 2:
                    return "Setup Pending";
                case 4:
                    return "Part/Machine Problems";
                case 5:
                    return "Completed PO";
                default:
                    return "";
            }
        }
    }
}