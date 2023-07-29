using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{

    public class Exported
    {
        public int ProductId { get; set; }
        public double ExportQuality { get; set; }
    }

    public class ApprovedOrderDetail {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime DueDate { get; set; }
        public int RequireNumber { get; set; }
        public string Note { get; set; }
    }

    public class OrderDetailModel {
        public OrderDetailModel() {
            OrderProcessDetails = new List<OrderProgressModel>();
            ApprovedOrderDetails = new List<ApprovedOrderDetail>();
        }
        public long OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public long OrderDetailId { get; set; }
        public bool IsApprove { get; set; }
        public bool IsAlert { get; set; }
        public int ProductId { get; set; }

        [UIHint("_ProductCodeNameTemplate")]
        [DisplayName("Mã Sản Phẩm")]
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDesignNo { get; set; }
        public string CustomerCode { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Số lượng")]
        [DataType("Number")]
        public double OrderQty { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tồn kho")]
        [DataType("Number")]
        public double AvailableQty { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Đơn giá")]
        [DataType("Number")]
        public double UnitPrice { get; set; }

        public double UnitPriceDiscount { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Thành tiền")]
        [DataType("Number")]
        public double LineTotal { get; set; }

        [UIHint("_CurrencyTemplate")]
        [DisplayName("Đvt")]
        public string Currency { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [UIHint("_DateTemplate")]
        [DisplayName("Ngày KH yêu cầu")]
        public DateTime? CustomerDueDate { get; set; }

        [UIHint("_DateTemplate")]
        [DisplayName("Ngày VFI giao")]
        public DateTime? VFIDueDate { get; set; }

        public DateTime? ProductionDate { get; set; }

        public string VfiDueDateString { get; set; }
        public string CreateDateString { get; set; }

        [DisplayName("Số lô")]
        public string LotNumber { get; set; }

        [DisplayName("Số mẫu")]
        public string ModelNumber { get; set; }

        public string PONumber { get; set; }

        public double RequiredNumber { get; set; }
        public string Note { get; set; }

        public double TotalInventory { get; set; }

        public int IsProductionManager { get; set; }
        public int IsSaleManager { get; set; }
        public int IsInvManager { get; set; }
        public double ForecastInMonth { get; set; }
        public double ProductivityInDay { get; set; }
        public double MachineRun { get; set; }
        public int DayProcess { get; set; }
        public bool IsProduction { get; set; }
        public bool DetailApproved { get; set; }
        public bool InForcast { get; set; }
        public bool ProductionApprove { get; set; }
        public bool ApproveType { get; set; }
        public int ExportDetailId { get; set; }

        public string OrderNote { get; set; }
        public List<OrderProgressModel> OrderProcessDetails { get; set; }
        public List<ApprovedOrderDetail> ApprovedOrderDetails { get; set; }

        public string ProcessNote { get; set; }
    }

    public static class OrderAutoNote {
        public static string GetOrderNote(List<ApprovedOrderDetail> list) {
            var note = "";
            var total = 0;
            foreach (var item in list) {
                note += "\n(" + item.OrderNumber + ":" +
                               item.DueDate.ToString("dd/MM") + "-" +
                               string.Format("{0:N0}", item.RequireNumber) + ")";
                total += item.RequireNumber;
            }
            return "Tổng ĐH khác: " + string.Format("{0:N0}", total) + " | " + note;
        }
        public static string GetProcessNote(List<string> list) {
            var note = "";
            foreach (var item in list) {
                note += item + ", ";
            }
            return note;
        }
    }

}