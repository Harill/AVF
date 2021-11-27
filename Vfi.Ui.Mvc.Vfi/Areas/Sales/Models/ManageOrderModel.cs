using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class ManageOrderModel
    {

        public long OrderId { get; set; }
        [UIHint("_ProductEditTemplate")]
        [DisplayName("Mã VF --- Mã SP Kh")]
        public string ProductCode { get; set; }

        [DisplayName("Số lượng")]
        [DataType("Number")]
        public double OrderQty { get; set; }

        [DisplayName("Đơn giá")]
        [DataType("Number")]
        public double UnitPrice { get; set; }

       // public double UnitPriceDiscount { get; set; }

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

        [DisplayName("Số lô")]
        public string LotNumber { get; set; }
        [DisplayName("Số mẫu")]
        public string ModelNumber { get; set; }

        [DisplayName("Mã KH")]
        public string CustomerCode { get; set; }

        [DisplayName("Tổng Số Lượng")]
        public int TotalQuality { get; set; }
        [DisplayName("Tổng GT ĐH")]
        public double TotalPrice { get; set; }
        [DisplayName("Tổng GT ĐH")]
        public string TotalPriceStr {
            get {
                var str = "";
                if (TotalPrice > 0) {
                    if (CurrencyCode.Equals("VND")) {
                        str = string.Format("{0:n0}", TotalPrice);
                    }
                    else {
                        str = string.Format("{0:n2}", TotalPrice);
                    }
                }
                return str;
            }
        }

        [DisplayName("Tổng Còn Lại")]
        public int TotalRequired { get; set; }
        [DisplayName("Tổng GT CL")]
        public double TotalRequiredPrice { get; set; }
        [DisplayName("Tổng GT CL")]
        public string TotalRequiredPriceStr {
            get {
                var str = "";
                if (TotalRequiredPrice > 0) {
                    if (CurrencyCode.Equals("VND")) {
                        str = string.Format("{0:n0}", TotalRequiredPrice);
                    }
                    else {
                        str = string.Format("{0:n2}", TotalRequiredPrice);
                    }
                }
                return str;
            }
        }
        [DisplayName("Tổng GT XB")]
        public double TotalExportedPrice {
            get {
                return TotalPrice - TotalRequiredPrice;
            }
        }
        [DisplayName("NV bán")]
        public string SalesPersonName { get; set; }

        [DisplayName("Ngày đặt lệnh")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [DisplayName("Ngày yêu cầu")]
        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }

        [DisplayName("Ngày chuyển")]
        [DataType(DataType.Date)]
        public DateTime? ShippedDate { get; set; }

        [DisplayName("Trạng thái")]
        public byte Status { get; set; }

        [DisplayName("Mã lệnh bán")]
        public string OrderNumber { get; set; }
        [DisplayName("Mã lệnh mua")]
        public string PoNumber { get; set; }


        [DisplayName("Địa chỉ bill")]
        public string BillToAddress { get; set; }
        [DisplayName("Địa chỉ ship")]
        public string ShipToAddress { get; set; }
        [DisplayName("Ghi chú")]
        public string Note { get; set; }

        [DisplayName("Đvt")]
        public string CurrencyCode { get; set; }

        public int ShipMethodId { get; set; }
        [DisplayName("Phương Thức")]
        public string ShipMethodName { get; set; }
        [DisplayName("Số ngày vận chuyễn")]
        public byte? ShipmentDay { get; set; }

        [DisplayName("Kích hoạt")]
        public bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public DateTime? ModifiedDate { get; set; }

        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        [DisplayName("Khu Vực")]
        public string Area { get; set; }

        [DisplayName("Trạng thái")]
        [UIHint("_StatusEditTemplate")]
        public string StatusName { get; set; }
    }
}