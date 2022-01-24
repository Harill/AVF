using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class OrderModel {
        public long OrderId { get; set; }

        public int CustomerId { get; set; }

        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        [DisplayName("Khách hàng")]
        public string CustomerCodeName { get { return CustomerCode + " -- " + CustomerName; } set { CustomerCode = value; } }

        [DisplayName("Nhân viên bán")]
        public int? SalesPersonId { get; set; }
        [DisplayName("Tổng Số Lượng")]
        public int TotalQuality { get; set; }
        [DisplayName("Nhân viên")]
        public string SalesPersonName { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Ngày đặt")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Ngày yêu cầu")]
        [UIHint("_DateTemplate")]
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

        [DisplayName("Số lô")]
        public string LotNumber { get; set; }
        [DisplayName("Số mẫu")]
        public string ModelNumber { get; set; }

        [DisplayName("Địa chỉ bill")]
        public string BillToAddress { get; set; }
        [DisplayName("Địa chỉ ship")]
        public string ShipToAddress { get; set; }
        [DisplayName("Ghi chú")]
        public string Note { get; set; }

        [DisplayName("Tiền tệ")]
        public string CurrencyCode { get; set; }

        public int ShipMethodId { get; set; }
        [DisplayName("Phương thức vận chuyển")]
        public string ShipMethodName { get; set; }
        [DisplayName("Số ngày vận chuyễn")]
        public byte? ShipmentDay { get; set; }

        public int PaymentMethodId { get; set; }
        [DisplayName("Phương thức thanh toán")]
        public string PaymentMethodName { get; set; }
        [DisplayName("Kích hoạt")]
        public bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public DateTime? ModifiedDate { get; set; }

        public string Area { get; set; }

        public int DetailStatus { get; set; }
        public bool SalesManager { get; set; }
        public bool CanApprove { get; set; }
    }
}