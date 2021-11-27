using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Sales
{
    public class OrderDomainModel: Order
    {
        public virtual new long SalesOrderId { get; set; }
        
        public virtual new int CustomerId { get; set; }
        public virtual string CustomerCode { get; set; }
        public virtual string CustomerName { get; set; }
        [DisplayName("Khách hàng")]
        public virtual string CustomerCodeName { get { return CustomerCode + " -- " + CustomerName; } set { CustomerCode = value; } }
        
        [DisplayName("Nhân viên bán")]
        public virtual new int? SalesPersonId { get; set; }
        [DisplayName("Nhân viên bán")]
        public virtual string SalesPersonName { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Ngày đặt lệnh")]
        [DataType(DataType.Date)]
        public virtual new DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Ngày yêu cầu")]
        [DataType(DataType.Date)]
        public virtual new DateTime? DueDate { get; set; }

        [DisplayName("Ngày vận chuyễn")]
        [DataType(DataType.Date)]
        public virtual new DateTime? ShipDate { get; set; }

        [DisplayName("Trạng thái")]
        public virtual new byte Status { get; set; }

        [DisplayName("Mã lệnh bán")]
        public virtual new string SalesOrderNumber { get; set; }
        [DisplayName("Mã lệnh mua")]
        public virtual new string PurchaseOrderNumber { get; set; }
        
        [DisplayName("Địa chỉ trên bill")]
        public virtual new string BillToAddress { get; set; }
        [DisplayName("Địa chỉ trên bill")]
        public virtual new string ShipToAddress { get; set; }

        public virtual new int? ShipMethodId { get; set; }
        [DisplayName("Pt vận chuyễn")]
        public virtual string ShipMethodName { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
