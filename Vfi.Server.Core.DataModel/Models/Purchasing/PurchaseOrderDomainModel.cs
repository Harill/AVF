using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Purchasing
{
    public class PurchaseOrderDomainModel: PurchaseOrder
    {
        public new long PurchaseOrderId { get; set; }
        
        // Vendor
        public new int VendorId { get; set; }

        [DisplayName("Tên nhà cung cấp")]
        public virtual string VendorName { get; set; }
        [DisplayName("Mã nhà cung cấp")]
        public virtual string VendorCode { get; set; }
        [DisplayName("Nhà cung cấp")]
        [UIHint("_VendorEditTemplate")]
        public virtual string VendorCodeName { get { return VendorCode + " -- " + VendorName; } set { VendorCode = value; } }
        // vendor

        public virtual new int ShipMethodId { get; set; }
        [DisplayName("Phương thức vận chuyển")]
        public virtual string ShipMethodName { get; set; }

        public virtual new int DeliveryMethodId { get; set; }
        [DisplayName("Phương thức giao hàng")]
        public virtual string DeliveryMethodName { get; set; }

        public virtual new int PackagedMethodId { get; set; }
        [DisplayName("Phương thức đóng gói")]
        public virtual string PackagedMethodName { get; set; }

        public virtual new int PaymentMethodId { get; set; }
        [DisplayName("Phương thức thanh toán")]
        public virtual string PaymentMethodName { get; set; }

        public virtual new int EmployeeId { get; set; }
        [DisplayName("Nhân viên")]
        public virtual string EmployeeName { get; set; }

        [DisplayName("Số đơn")]
        public virtual new string RevisionNumber { get; set; }

        [DisplayName("Trạng thái")]
        public virtual new byte Status { get; set; }
        [DisplayName("Trạng thái")]
        public virtual string StatusName { get; set; }

        [DisplayName("Ngày đặt lệnh")]
        [DataType("DateNonNullable")]
        public virtual new DateTime OrderDate { get; set; }

        [DisplayName("Ngày giao")]
        [DataType(DataType.Date)]
        public virtual new DateTime? ShipDate { get; set; }
        
        //[UIHint("_PurchaseOrderDetailEditTemplate")]
        //public virtual string GridDetail { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
        public string Note { get; set; }
    }
}
