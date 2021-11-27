using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Inv
{
    public class ProductInventoryPeriodDomainModel: ProductInventoryPeriod
    {
        public virtual new long ProductInventoryPeriodId { get; set; }
        
        // Transaction
        public virtual new long TransactionId { get; set; }
        [DisplayName("Mã giao dịch")]
        public virtual string TransactionNumber { get; set; }
        // Transaction

        // warehouse
        public virtual new int WarehouseId { get; set; }
        [DisplayName("Kho sản phẩm")]
        public virtual string WarehouseName { get; set; }

        public virtual int? WarehouseIdx { get; set; }
        // warehouse

        // product
        public virtual new int ProductId { get; set; }
        [DisplayName("Mã sản phẩm")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public string ProductCode { get; set; }

        [DisplayName("Tên sản phẩm")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public string ProductName { get; set; }

        [DisplayName("Sản phẩm")]
        public virtual string ProductCodeName { get { return ProductCode + " -- " + ProductName; } set { ProductCode = value; } }
        // product

        [DisplayName("Kỳ trong ngày")]
        public virtual new int? PeriodDay { get; set; }
        [DisplayName("Kỳ trong tháng")]
        public virtual new int? PeriodMonth { get; set; }
        [DisplayName("Kỳ trong năm")]
        public virtual new int? PeriodYear { get; set; }
        [DisplayName("Kỳ")]
        public virtual new DateTime? PeriodDate { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tồn đầu (PCS)")]
        [DataType("Number")]
        public virtual new double? EarlyPeriodQuantity { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayName("Giá đầu kỳ")]
        [DataType("Number")]
        public virtual new double? EarlyPeriodPrice { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Số lượng")]
        [DataType("Number")]
        public virtual new double? Quantity { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Giá thành phẩm")]
        [DataType("Number")]
        public virtual new double? UnitPrice { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Giá")]
        [DataType("Number")]
        public virtual new double? Price { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Đơn vị tính")]
        public virtual new string UnitMeasure { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tồn cuối (PCS)")]
        [DataType("Number")]
        public virtual new double? LastPeriodQuantity { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Giá cuối kỳ")]
        [DataType("Number")]
        public virtual new double? LastPeriodPrice { get; set; }

        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
