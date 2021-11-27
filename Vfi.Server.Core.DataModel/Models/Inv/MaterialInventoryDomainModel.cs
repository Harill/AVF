using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Inv
{
    public class MaterialInventoryDomainModel
    {
        public virtual  int MaterialInventoryId { get; set; }
        public virtual  int MaterialId { get; set; }
        public virtual  long PurchaseOrderDetailId { get; set; }

        public virtual  int Id { get; set; }

        [DisplayName("Mã nguyên liệu")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public virtual string Code { get; set; }

        [DisplayName("Tên nguyên liệu")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public virtual string Name { get; set; }

        [DisplayName("Nguyên liệu")]
        public virtual string CodeName { get { return Code + " -- " + Name; } set { Code = value; } }

        [DisplayName("Đơn vị tính")]
        public virtual string Unit { get; set; }

        [DisplayName("Mã nguyên liệu")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public virtual string MaterialCode { get; set; }

        [DisplayName("Tên nguyên liệu")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public virtual string MaterialName { get; set; }

        [DisplayName("Nguyên liệu")]
        public virtual string MaterialCodeName { get { return MaterialCode + " -- " + MaterialName; } set { MaterialCode = value; } }

        public virtual  int? WarehouseId { get; set; }
        [DisplayName("Kho nguyên liệu")]
        public virtual string WarehouseName { get; set; }

       // [Required(ErrorMessage = "* slg tổng cây")]
        [DisplayName("Slg tổng cây")]
        [DataType("Number")]
        public virtual  double TotalQty { get; set; }

       // [Required(ErrorMessage = "* slg tổng Kg")]
        [DisplayName("Slg tổng Kg")]
        [DataType("Number")]
        public virtual  double TotalQtyKg { get; set; }

        [DisplayName("Slg được dùng")]
        [DataType("Number")]
        public virtual  double AvailableQty { get; set; }

        [Required(ErrorMessage = "* slg dag dùng")]
        [DisplayName("Slg đang dùng")]
        [DataType("Number")]
        public virtual  double UnavailableQty { get; set; }

        [DisplayName("Đơn vị tính")]
        public virtual  string UnitMeasure { get; set; }

        [DisplayName("Số lô")]
        public virtual  string LotNumber { get; set; }
        [DisplayName("Trạng thái")]
        public virtual  byte Status { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime ModifiedDate { get; set; }
    }
}
