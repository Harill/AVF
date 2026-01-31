using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Production
{
    public class ProductDomainModel: Product
    {
        public new virtual int ProductId { get; set; }

        public new int CustomerId { get; set; }
        [DisplayName("Mã khách hàng")]
        public virtual string CustomerCode { get; set; }
        [DisplayName("Tên khách hàng")]
        public string CustomerName { get; set; }
        [DisplayName("Customer")]                                               // khach hang
        public virtual string CustomerCodeName { get { return CustomerCode + " -- " + CustomerName; } set { CustomerCode = value; } }

        public virtual string CustomerCodeOnly { get { return CustomerCode + " -- " + CustomerName; } set { CustomerCode = value; } }
        public new virtual int MaterialId { get; set; }
        //[Required(ErrorMessage = "*")]
        [DisplayName("Mã nguyên liệu")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        //[UIHint("_MaterialEditTemplate")]
        public virtual string MaterialCode { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Tên nguyên liệu")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        //[UIHint("_MaterialEditTemplate")]
        public virtual string MaterialName { get; set; }

        [DisplayName("Nguyên liệu")]
        //[Required(ErrorMessage = "*")]
        //[UIHint("_MaterialEditTemplate")]
        public virtual string MaterialCodeName { get { return MaterialCode + " -- " + MaterialName; } set { MaterialCode = value; } }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Mã VF")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public new string ProductCode { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Product Name")]                         // Ten sp KH
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public new string ProductName { get; set; }

        [DisplayName("Thành phẩm")]
        public virtual string ProductCodeName { get { return ProductCode + " -- " + ProductName; } set { ProductCode = value; } }

        [DisplayName("Thành phẩm")]
        public virtual string ProductFullCodeName { get { return DesignNo + " -- "+ProductCode + " -- " + ProductName; } set { ProductCode = value; } }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Product Code")]                       // Ma sp KH
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public virtual new string DesignNo { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Đường kính ngoài")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.01 < * < double.MaxValue")]
        public new virtual double? Diameter { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Đường kính trong")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.01 < * < double.MaxValue")]
        public new virtual double? InDiameter { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Chiều dài")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.01 < * < double.MaxValue")]
        public new virtual double? Length { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Trọng lượng")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.01 < * < double.MaxValue")]
        public new virtual double? Weight { get; set; }

        [DisplayName("Kích hoạt")]
        public new virtual bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new virtual string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new virtual DateTime? ModifiedDate { get; set; }

        [DisplayName("Có bán")]
        public new virtual bool IsSelling { get; set; }
        //[Required(ErrorMessage = "*")]
        [DisplayName("Đơn giá")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.01 < * < double.MaxValue")]
        public new virtual double? UnitPrice { get; set; }

        public new virtual string UnitPriceFormat { get; set; }

        [DisplayName("Dự báo SX")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public new virtual double? ForecastsQuality { get; set; }

        [DisplayName("Trọng lượng SX")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public Nullable<double> ProductionWeight { get; set; }
        [DisplayName("Định mức thiết kế")]
        [DataType("Number")]
        public Nullable<int> ProductionRate { get; set; }
        [DisplayName("Trọng lượng GCN")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public Nullable<double> OutsideProcessWeight { get; set; }
        [DisplayName("Năng suất thiết kế(giây/con)")]
        [DataType("NumberAsInt")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public Nullable<double> Productivity { get; set; }

        [DisplayName("Hệ số bán hàng")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public double SalesFactor { get; set; }
        [DisplayName("Hệ số SX")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public double ProductionFactor { get; set; }
        [DisplayName("Trọng lượng kho CNC")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public double CncWeight { get; set; }
        [DisplayName("Trọng lượng SX2")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public double Production2Weight { get; set; }
        [DisplayName("Trọng lượng trước xi")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public double WaitingPlatingWeight { get; set; }
        [DisplayName("Trọng lượng sau xi")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public double PlatingWeight { get; set; }
        [DisplayName("Trọng lượng QC")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public double QcWeight { get; set; }
        [DisplayName("Trọng lượng thành phẩm")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public double FinishWeight { get; set; }
        [DisplayName("Trọng lượng nhiệt luyện")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public double HeatTreatmentWeight { get; set; }
        [DisplayName("Trọng lượng rung bóng")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public double SurfaceTreatmentWeight { get; set; }


        [DisplayName("Tên nguyên liệu thiết kế")]
        public string MaterialNameDesign { get; set; }
        [DisplayName("Đường kính ngoài")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public double OutDiameterDesign { get; set; }
        [DisplayName("Dung sai đường kính ngoài")]
        public string OutDiameterTolerance { get; set; }
        [DisplayName("Đường kính trong")]
        [DataType("Number")]
        [Range(0.0, double.MaxValue, ErrorMessage = "0.0 < * < double.MaxValue")]
        public double InDiameterDesign { get; set; }
        [DisplayName("Dung sai đường kính trong")]
        public string InDiameterTolerance { get; set; }
        public string ShapeDesign { get; set; }
    }
}
