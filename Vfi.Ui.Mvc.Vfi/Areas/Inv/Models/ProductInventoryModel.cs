using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ProductInventoryModel
    {
        public string ProductCodeInv
        {
            get { return CustomerCode + " - " + ProductCode + " - " + LotNumber; }
        }

        [DataType("Number0")]
        public virtual double Quantity { get; set; }
        public string LotNumber { get; set; }
        //public double ProductWeight { get; set; }

        public string Print2 { get; set; }
        public string PreviousProcess { get;set; }
        public string NextProcess { get; set; }
        public int NextWarehouseId { get; set; }
        public string NextWarehouseIds { get; set; }

        public virtual new int ProductInventoryId { get; set; }

        // product
        public virtual new int ProductId { get; set; }
        [DisplayName("Mã sản phẩm")]
        //[StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public string ProductCode { get; set; }

        [DisplayName("Tên sản phẩm")]
        //[StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public string ProductName { get; set; }


        [DisplayName("Sản phẩm")]
        public virtual string ProductCodeName { get { return ProductCode + " -- " + ProductName; } set { ProductCode = value; } }
        // product

        // customer
        public string CustomerCode { get; set; }

        // warehouse
        public virtual new int WarehouseId { get; set; }
        [DisplayName("Kho nguyên liệu")]
        public virtual string WarehouseName { get; set; }
        // warehosue

        [DisplayName("Tồn cuối (PCS)")]
        [DataType("Number")]
        public virtual new double TotalQty { get; set; }
        [DisplayName("Tồn cuối (g)")]
        [DataType("Number")]
        public virtual new double TotalQtyKg { get { return TotalQty * ProductWeight; } }

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
        public new DateTime ModifiedDate { get; set; }
        public string Note { get; set; }
        public string ProductImg { get; set; }
        public string UploadDate { get; set; }
        public bool CanRotate { get; set; }
        public string StoreCode { get; set; }
    }

    public class ProductInventoryImportModel : ProductInventoryModel
    {
        

        public bool EoI { get; set; }

        [DataType("Number0")]
        public new virtual double Quantity { get; set; }
    }
    public class ProductExpotTP : ProductInventoryRotateModel
    {
        [Required(ErrorMessage = @"Vui lòng nhập số lượng.")]
        public new virtual double Quantity { get; set; }
        
    }

    public class ProductInventoryRotateModel
    {
        public virtual long ProductInventoryIssueId { get; set; }
        public virtual long ProductInventoryReceiptId { get; set; }
        public virtual bool IsRotateAll { get; set; }
        [DataType("Number0")]
        public double Weight { get; set; }
        public int SmallBoxNum { get; set; }
        public int BigBoxNum { get; set; }
        [DisplayName(@"Tồn xuất (PCS)")]
        public virtual double TotalQtyExport { get; set; }
        [DisplayName(@"Tồn xuất (Kg)")]
        public virtual double TotalQtyExportKg { get { return TotalQtyExport * ProductWeight; } }
        [DisplayName(@"Tồn nhập (PCS)")]
        public virtual double TotalQtyImport { get; set; }
        [DisplayName(@"Tồn nhập (Kg)")]
        public virtual double TotalQtyImportKg { get { return TotalQtyImport*ProductWeight; } }

        [DataType("Number0")]
        public new virtual double Quantity { get; set; }

        [DataType("Number0")]
        public virtual double QuantityKg { get; set; }
        public int ErrorId { get; set; }
        [DataType("_ErrorEditTemplate")]
        public string ErrorName { get; set; }
        [DataType("_ProductCodeEditTemplate")]
        public new string ProductCode { get; set; }
        public string ProductImg { get; set; }
        public long TransactionId { get; set; }
        public long TransactionProductId { get; set; }

        public string ProductCodeInv
        {
            get { return CustomerCode + " - " + ProductCode + " - " + LotNumber; }
        }

        public string LotNumber { get; set; }
        //public double ProductWeight { get; set; }

        public string Print2 { get; set; }
        public string PreviousProcess { get; set; }
        public string NextProcess { get; set; }
        public int NextWarehouseId { get; set; }
        public string NextWarehouseIds { get; set; }

        public virtual new int ProductInventoryId { get; set; }

        // product
        public virtual new int ProductId { get; set; }

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
        public virtual new double TotalQtyKg { get { return TotalQty * ProductWeight; } }

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
        public new DateTime ModifiedDate { get; set; }
        public string Note { get; set; }

        public int GroupIndex { get; set; }
        public string StoreCode { get; set; }
    }
}