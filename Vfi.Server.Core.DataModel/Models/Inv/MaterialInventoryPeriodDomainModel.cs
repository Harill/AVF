using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Inv
{
    public class MaterialInventoryPeriodDomainModel: MaterialInventoryPeriod
    {
        public virtual new long MaterialInventoryPeriodId { get; set; }
        
        // Transaction
        public virtual new long TransactionId { get; set; }
        [DisplayName("Mã giao dịch")]
        public virtual string TransactionNumber { get; set; }
        // Transaction

        // Warehouse
        public virtual new int WarehouseId { get; set; }
        [DisplayName("Kho nguyên liệu")]
        public virtual string WarehouseName { get; set; }
        // Warehouse

        // Material
        public virtual new int MaterialId { get; set; }

        [DisplayName("Mã nguyên liệu")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public virtual string MaterialCode { get; set; }

        [DisplayName("Tên nguyên liệu")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public virtual string MaterialName { get; set; }

        [DisplayName("Nguyên liệu")]
        public virtual string MaterialCodeName { get { return MaterialCode + " -- " + MaterialName; } set { MaterialCode = value; } }
        // Material

        [DisplayName("Kỳ trong ngày")]
        public virtual new int? PeriodDay { get; set; }
        [DisplayName("Kỳ trong tháng")]
        public virtual new int? PeriodMonth { get; set; }
        [DisplayName("Kỳ trong năm")]
        public virtual new int? PeriodYear { get; set; }
        [DisplayName("Kỳ")]
        public virtual new DateTime? PeriodDate { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tồn đầu/cây")]
        [DataType("Number")]
        public virtual new double? EarlyPeriodQuantity { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tồn đầu/kg")]
        [DataType("Number")]
        public virtual new double? EarlyPeriodQuantityKg { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Giá đầu kỳ")]
        [DataType("Number")]
        public virtual new double? EarlyPeriodPrice { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Nhập xuất/cây")]
        [DataType("Number")]
        public virtual new double? Quantity { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Nhập xuất/kg")]
        [DataType("Number")]
        public virtual new double? QuantityKg { get; set; }

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
        [DisplayName("Tồn cuối/cây")]
        [DataType("Number")]
        public virtual new double? LastPeriodQuantity { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tồn cuối/kg")]
        [DataType("Number")]
        public virtual new double? LastPeriodQuantityKg { get; set; }

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
