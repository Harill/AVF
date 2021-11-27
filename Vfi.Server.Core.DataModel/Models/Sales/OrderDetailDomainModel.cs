using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Sales
{
    public class OrderDetailDomainModel: OrderDetail
    {
        public virtual new long SalesOrderDetailId { get; set; }
        public virtual new long SalesOrderId { get; set; }

        public virtual new int ProductId { get; set; }
        [DisplayName("Mã thành phẩm")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public virtual string ProductCode { get; set; }
        [DisplayName("Tên thành phẩm")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public virtual string ProductName { get; set; }
        [DisplayName("Thành phẩm")]
        public virtual string ProductCodeName { get { return ProductCode + " -- " + ProductName; } set { ProductCode = value; } }
        
        [DisplayName("Số lô hàng")]
        public virtual new string CarrierTrackingNumber { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Số lượng")]
        [DataType("NumberAsShort")]
        public virtual new short OrderQty { get; set; }
        
        [Required(ErrorMessage = "*")]
        [DisplayName("Đơn giá")]
        [DataType("Number")]
        public virtual new double UnitPrice { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Giảm giá")]
        [DataType("Number")]
        public virtual new double UnitPriceDiscount { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Thành tiền")]
        [DataType("Number")]
        public virtual new double LineTotal { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
