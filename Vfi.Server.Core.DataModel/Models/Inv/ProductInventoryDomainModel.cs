using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Inv
{
    public class ProductInventoryDomainModel: ProductInventory
    {
        public virtual new int ProductInventoryId { get; set; }
        
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

        // customer
        public string CustomerCode { get; set; }

        // warehouse
        public virtual new int? WarehouseId { get; set; }
        [DisplayName("Kho nguyên liệu")]
        public virtual string WarehouseName { get; set; }
        // warehosue

        [DisplayName("Tồn cuối (PCS)")]
        [DataType("Number")]
        public virtual new double TotalQty { get; set; }

        [DisplayName("Slg được dùng")]
        [DataType("Number")]
        public virtual new double AvailableQty { get; set; }
        public virtual new double AvailableQtyKg { get { return AvailableQty * ProductWeight; } }
        public double ProductWeight { get; set; }

        [DisplayName("Slg đang dùng")]
        [DataType("Number")]
        public virtual new double UnavailableQty { get; set; }

        [DisplayName("Đơn vị tính")]
        public virtual new string UnitMeasure { get; set; }

        [DisplayName("Trạng thái")]
        public virtual new byte Status { get; set; }


        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
        public string Note { get; set; }
    }
}
