using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Inv
{
    public class StockOrderDetailDomainModel: StockOrderDetail
    {
        public virtual new long StockOrderDetailId { get; set; }
        public virtual new long StockOrderId { get; set; }

        public virtual new int? ReferenceId { get; set; }

        // material

        [DisplayName("Mã nguyên liệu")]
        public virtual string MaterialCode { get; set; }

        [DisplayName("Tên nguyên liệu")]
        public virtual string MaterialName { get; set; }

        [DisplayName("Nguyên liệu")]
        public virtual string MaterialCodeName { get { return MaterialCode + " -- " + MaterialName; } set { MaterialCode = value; } }

        // material

        // product
        [DisplayName("Mã thành phẩm")]
        public string ProductCode { get; set; }

        [DisplayName("Tên thành phẩm")]
        public string ProductName { get; set; }

        [DisplayName("Thành phẩm")]
        public virtual string ProductCodeName { get { return ProductCode + " -- " + ProductName; } set { ProductCode = value; } }
        // product

        [DisplayName("Nliệu ? Tphẩm")]
        public virtual new bool MoP { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Số lượng")]
        [DataType("Number")]
        public virtual new double? Quantity { get; set; }
        
        [DisplayName("Đơn vị tính")]
        public virtual string UnitMeasureCode { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayName("Đơn vị tính")]
        public virtual string UnitMeasureCodeName { get; set; }


        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
