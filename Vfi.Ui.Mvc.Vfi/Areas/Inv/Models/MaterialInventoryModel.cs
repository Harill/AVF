
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.Models.Inv;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class MaterialInventoryModel: MaterialInventoryDomainModel
    {
        public MaterialInventoryModel()
        {
            UnitWeight = 0;
            ImportMore = 0;
            ExportDestroy = 0;
            ExportUse = 0;
            ImportPurchase = 0;
            VendorCode = "";
            LotNumber = "";
        }

        public string UploadDate { get; set; }
        //[Required(ErrorMessage = @"Vui lòng nhập số lượng.")]
        public string InfoImg { get; set; }
        public string InfoImg2 { get; set; }
        [DisplayName(@"Số lượng(Cây)")]
        [DataType("Number")]
        public double Quantity { get; set; }
        public int MaterialTypeId { get; set; }
        public string MaterialTypeCode { get; set; }
        public string MaterialCodeLotNumber
        {
            get
            {
                return
                    MyUtilities.Material.GetMaterialInvDesignNo(MaterialName, OutDiameter, InDiameter, Length,
                                                                DiameterType, Shape, VendorCode, LotNumber);
            }
        }
        public string DesignNo { get; set; }
        public double MaterialInvOnMachine { get; set; }
        public string Shape { get; set; }
        public double OutDiameter { get; set; }
        public double InDiameter { get; set; }
        public string DiameterType { get; set; }
        public double Length { get; set; }

        public DateTime FirstUseDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ImportDate { get; set; }


        public string StoreCode { get; set; }

        public int DrawerId { get; set; }
        [DataType("_InventoryDrawerTemplate")]
        public string DrawerCode { get; set; }

        public int VendorId { get; set; }
        [DisplayName("Nhà cung cấp")]
        public string VendorCode { get; set; }
        [DisplayName("Nhà cung cấp")]
        public string VendorName { get; set; }
        [Required(ErrorMessage = "*")]
        [UIHint("_VendorEditTemplate")]
        [DisplayName("Nhà cung cấp")]
        public string VendorCodeName
        {
            get
            {
                return VendorCode + " -- " + VendorName;
            }
            set
            {
                VendorCode = value;
            }
        }

        //[Required(ErrorMessage = @"Vui lòng nhập số lượng.")]
        //[Range(0.01, double.MaxValue, ErrorMessage = @" 0 < Slg nhập < max")]
        [DisplayName(@"Trọng lượng(kg)")]
        [DataType("Number")]
        public double QuantityKg { get; set; }
        [DisplayName(@"Ghi Chú")]
        public string Note { get; set; }
        [DisplayName("Tồn cuối(Cây)")]
        public override double TotalQty
        {
            get
            {
                return base.TotalQty;
            }
            set
            {
                base.TotalQty = value;
            }
        }

        [DisplayName("Tồn cuối(Kg)")]
        public override double TotalQtyKg
        {
            get
            {
                return base.TotalQtyKg;
            }
            set
            {
                base.TotalQtyKg = value;
            }
        }

        [DisplayName("Giá/Cây")]
        [DataType("Number")]
        public double Price { get; set; }

        [UIHint("_unitMeasureEditTemplate")]
        public override string UnitMeasure
        {
            get
            {
                return base.UnitMeasure;
            }
            set
            {
                base.UnitMeasure = value;
            }
        }


        [DataType("Number")]
        [DisplayName(@"Đơn giá")]
        public double UnitPrice { get; set; }
        [DataType("Number")]
        [DisplayName(@"Trọng lượng")]
        public double UnitWeight { get; set; }

        
        public double TotalImport { get; set; }
        public double TotalImportKg { get; set; }
        public double ImportPurchase { get; set; }
        public double ImportPurchaseKg { get { return ImportPurchase * UnitWeight; } }
        public double ImportMore { get; set; }
        public double ImportMoreKg { get { return ImportMore*UnitWeight; } }
        public double TotalExport { get; set; }
        public double TotalExportKg { get { return TotalExport * UnitWeight; } }
        public double ExportUse { get; set; }
        public double ExportUseKg { get { return ExportUse * UnitWeight; } }
        public double ExportDestroy { get; set; }
        public double ExportDestroyKg { get { return ExportDestroy * UnitWeight; } }
        public double DestroyOnMachine { get; set; }
        public double EarlyQuantity { get; set; }
        public double EarlyQuantityKg { get; set; }
        public double LastQuantity { get; set; }
        public double LastQuantityKg { get; set; }
        public double TotalInv { get; set; }
        public bool IsDestroy { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public double ProductionDiff { get; set; }
        public double MaterialWorkpiece { get; set; }
        public double Require { get; set; }
    }

    public class ProductionMaterialMachine
    {
        public int MaterialInvId { get; set; }
        public int MachineId { get; set; }
        public int ProductId { get; set; }
        public double SendBack { get; set; }
        public string ProductCode { get; set; }
        public string MachineName { get; set; }
        public double MaterialInvOnMachine { get; set; }
        public double TotalAssign { get; set; }
        public double TotalUse { get; set; }
        public double TotalDestroy { get; set; }
        public double ProductionDiff { get; set; }
        public double MaterialDiff { get; set; }
        public int Day { get; set; }
        public double Require { get; set; }
    }

    public class ProductionMaterialMachineDetail
    {
        public ProductionMaterialMachineDetail()
        {
            Quantity = 0;
            Process = 0;
            Defect = 0;
            //QuantityDesign = 0;
            //ProductRate = 1;
            Productivity = 0;
            ProductLength = 0;
            KnifeCut = 0;
            MaterialLength = 0;
            OutDiamter = 0;
        }

        public int MaterialInvId { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public DateTime Date { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }
        public double SendBack { get; set; }
        public double TotalAssign { get; set; }
        public double TotalUse { get; set; }
        public double TotalDestroy { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double Productivity { get; set; }
        public double Require { get; set; }

        public double MaxAssign
        {
            get {
                return MyUtilities.Product.GetMaterialRateInFactoryDayTime(Productivity, ProductRate);
                //return (Productivity > 0 && ProductRate > 1)
                //           ? MyUtilities.Product.Second20h/Productivity/ProductRate
                //           : 0;
            }
        }

        public string MaterialDesign { get; set; }

        public double QuantityDesign
        {
            get { return TotalUse*ProductRate; }
        }

        //public double QuantityDesign { get; set; }
        public double Quantity { get; set; }
        public double Process { get; set; }
        public double Defect { get; set; }

        public double ProductionDiff
        {
            get { return Quantity + Process + Defect - QuantityDesign; }
        }

        //public double MaterialDiff { get; set; }
        public double MaterialDiff
        {
            get
            {
                return ProductRate > 1
                           ? ProductionDiff/ProductRate
                           : 0;
            }
        }
        public double MaterialWorkpiece { get; set; }

        //public double ProductRate { get; set; }
        public double ProductRate
        {
            get
            {
                return ProductLength + KnifeCut > 0
                           ? MyUtilities.Product.GetProductRate(MaterialLength, MaterialWorkpiece, ProductLength, KnifeCut)
                           : 1;
            }
        }

        /*
         * <4 knife cut =1.5
         * <7 = 2
         * <11 = 2.5
         * <19 = 3
         */
        public double MaterialLength { get; set; }
        public double ProductLength { get; set; }
        public double OutDiamter { get; set; }
        public double KnifeCut { get; set; }
        //public double KnifeCut 
        //{
        //    get
        //    {
        //        return
        //            OutDiamter < 4
        //                ? 1.5
        //                : OutDiamter < 7
        //                      ? 2
        //                      : OutDiamter < 11
        //                            ? 2.5
        //                            : 3;
        //    }
        //}
    }

    public class MaterialInventoryImportModel: MaterialInventoryModel
    {
        public bool EoI { get; set; }
        
        [DisplayName(@"Số lượng xuất")]
        //[Remote("CheckExportQuantity", "Inv", AdditionalFields = "TotalQty" )]
        //[LessThanOrEqualToProperty(OtherProperty = "TotalQty")]
        //[EqualToProperty(OtherProperty = "TotalQty")]
        public double Quantity
        {
            get
            {
                return base.Quantity;
            }
            set
            {
                base.Quantity = value;
            }
        }
    }

    public class MaterialInventoryRotateModel : MaterialInventoryModel
    {
        public virtual long MaterialInventoryIssueId { get; set; }
        public virtual long MaterialInventoryReceiptId { get; set; }

        public override string MaterialCodeName
        {
            get
            {
                return base.MaterialCode + " -- " + base.MaterialName;
            }
            set
            {
                base.MaterialCodeName = value;
            }
        }

        [DisplayName(@"Tồn xuất")]
        public virtual double TotalQtyExport { get; set; }

        [DisplayName(@"Tồn nhập")]
        public virtual double TotalQtyImport { get; set; }

        [DisplayName(@"Số lượng chuyển")]
        public double Quantity
        {
            get
            {
                return base.Quantity;
            }
            set
            {
                base.Quantity = value;
            }
        }
    }

}