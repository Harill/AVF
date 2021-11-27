using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Inv
{
    public class TransactionDetailDomainModel : TransactionDetail
    {
        public virtual new long TransactionDetailId { get; set; }
        public virtual new long? TransactionId { get; set; }
        public virtual new int? ReferenceId { get; set; }


        // material
        [DisplayName("Mã NL")]
        public virtual string MaterialCode { get; set; }

        [DisplayName("Tên NL")]
        public virtual string MaterialName { get; set; }

        [DisplayName("Nguyên liệu")]
        public virtual string MaterialCodeName { get { return MaterialCode + " -- " + MaterialName; } set { MaterialCode = value; } }
        // material

        // product
        [DisplayName("Mã sản phẩm")]
        public string ProductCode { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string ProductName { get; set; }


        [DisplayName("Mã Khách Hàng")]
        public string CustomerCode { get; set; }


        [DisplayName("Sản phẩm")]
        public virtual string ProductCodeName { get { return ProductCode + " -- " + ProductName; } set { ProductCode = value; } }
        // product

        [DisplayName("Nliệu ? Tphẩm")]
        public virtual new bool MoP { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Số lượng")]
        [DataType("Number")]
        public virtual new double? Quantity { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Tồn cây")]
        [DataType("Number2")]
        public virtual new double? AvailableQuantity { get; set; }
        //[Required(ErrorMessage = "*")]
        [DisplayName("Tồn Kg")]
        [DataType("Number2")]
        public virtual new double? AvailableQuantityKg { get; set; }
        //[Required(ErrorMessage = "*")]
        [DisplayName("Số lượng Kg")]
        [DataType("Number")]
        public virtual new double? QuantityKg { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Đơn vị tính")]
        public virtual new string UnitMeasure { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Giá nguyên liệu")]
        [DataType("Number")]
        public virtual new double? Price { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
