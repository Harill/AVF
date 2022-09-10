using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class SmartProductionModel
    {
        public SmartProductionModel ()
        {
            MaterialName = "";
            MaterialInventoryCode = "";
            ProductCode = "";
            StoreCode = "";
            MaterialUse1 = 0;
            MaterialUse2 = 0;
            DiffMaterial1 = 0;
            DiffMaterial2 = 0;
            IsLimit = true;
            LimitColor = 0;
        }
        public string SmartType { get; set; }
        public int SmartId { get; set; }
        public int MachineId { get; set; }

        [UIHint("_UnitMeasureEditTemplate")]
        public string UnitMeasure { get; set; }

        [UIHint("_MachineEditTemplate")]
        public string MachineName { get; set; }

        public int ProductId { get; set; }

        [UIHint("_ProductEditTemplate")]
        public string ProductCode { get; set; }

        public int ProductCodeLength
        {
            get { return string.IsNullOrWhiteSpace(ProductCode) ? 0 : ProductCode.Length; }
        }

        [DataType("Number")]
        public double ProductWeight { get; set; }
        public double ProductWeightStatus { get; set; }
        public int ProductAlert { get; set; }

        public int MaterialId { get; set; }
        public int MaterialUseId { get; set; }

        [UIHint("_MaterialEditTemplate")]
        public string MaterialCode { get; set; }
        public string VendorCode { get; set; }
        public string MaterialName { get; set; }
        public int MaterialNameLength { get { return MaterialInventoryCode.Length; } }
        public double OutDiameter { get; set; }
        public double InDiameter { get; set; }
        public string Shape { get; set; }
        public string DiameterType { get; set; }
        public string LotNumber { get; set; }
        public double Length { get; set; }
        public string StoreCode { get; set; }
        public int StoreCodeLength { get { return string.IsNullOrWhiteSpace(StoreCode) ? 0 : (StoreCode + "").Length; } }
        public int MaterialStatus { get; set; }

        public int MaterialInventoryId { get; set; }
        public int MaterialInvOnMachineId { get; set; }
        public double MaterialInvOnMachine { get; set; }
        public double MaterialInvTotal { get; set; }
        public double MaterialAllInvTotal { get; set; }
        public double DiffProduction { get; set; }
        public double DiffMaterial { get; set; }
        public double DiffMaterial1 { get; set; }
        public double DiffMaterial2 { get; set; }
        public double DiffMaterial1Rate { get { return MaterialUse1 > 0 ? Math.Abs(DiffMaterial1 / MaterialUse1) : DiffMaterial1 > 0 ? 1 : 0; } }
        public double DiffMaterial2Rate { get { return MaterialUse2 > 0 ? Math.Abs(DiffMaterial2 / MaterialUse2) : DiffMaterial2 > 0 ? 1 : 0; } }
        [UIHint("_MaterialInventoryEditTemplate")]
        public string MaterialInventoryCode { get; set; }
        public int MaterialAlert { get; set; }

        public int WarehouseExportId { get; set; }

        [UIHint("_WarehouseEditTemplate")]
        public string WarehouseExportName { get; set; }

        public string Shift1Name { get; set; }
        [DataType("Number")]
        public double MaterialUse1 { get; set; }

        [DataType("Number")]
        public double QuantityExport1 { get; set; }

        [DataType("Number")]
        public double QuantityPending1 { get; set; }

        [DataType("Number")]
        public double QuantityDefect1 { get; set; }

        public string Shift2Name { get; set; }
        [DataType("Number")]
        public double MaterialUse2 { get; set; }

        [DataType("Number")]
        public double QuantityExport2 { get; set; }

        [DataType("Number")]
        public double QuantityPending2 { get; set; }

        [DataType("Number")]
        public double QuantityDefect2 { get; set; }

        [DataType("NumberAll2")]
        public double QuantityDiff1 { get; set; }
        [DataType("NumberAll2")]
        public double QuantityDiff2 { get; set; }

        public bool IsChange { get; set; }
        public string Note { get; set; }

        public byte ShiftType { get; set; }
        public string ShiftName { get; set; }
        public int ProductionRate { get; set; }
        public int ProductionRateStatus { get; set; }
        public double Productivity { get; set; }
        public double ProductivityInShift
        {
            get
            {
                return MyUtilities.Product.GetProductionRateInFactoryShiftTime(Productivity) * ProductWeight;
            }
        }
        public double MaterialInShift
        {
            get
            {
                return MyUtilities.Product.GetMaterialRateInFactoryShiftTime(Productivity, ProductionRate);
            }
        }
        public int FuelInvId { get; set; }
        [UIHint("_FuelInventoryEditTemplate")]
        public string FuelFullCode { get; set; }
        public double FuelInvTotal { get; set; }

        public int ToolInvId { get; set; }
        [UIHint("_ToolInventoryEditTemplate")]
        public string ToolFullCode { get; set; }
        public double ToolInvTotal { get; set; }
        public DateTime UseDate { get; set; }
        public string UseDateString { get; set; }
        public string UseDateString2 { get; set; }
        public double MaxAssign { get; set; }
        public double Require { get; set; }
        public int ProcessByMachineId { get; set; }
        //{
        //    get
        //    {
        //        return MaxAssign > MaterialInvOnMachine
        //                   ? MaxAssign - MaterialInvOnMachine
        //                   : 0;
        //    }
        //}
        public string GetProductionLog()
        {
            string a = MaterialInventoryCode + "(cây) - Ca1:" + (MaterialUse1)
                       + " - Ca2:" + (MaterialUse2);
            a += " || "+ProductCode + "(pcs) - Ok:" + (QuantityExport1 + QuantityExport2)
                       + " - CXL:" + (QuantityPending1 + QuantityPending2)
                       + " - PP:" + (QuantityDefect1 + QuantityDefect2);
            return a;
        }
        public int TotalCames { get; set; }
        public int TotalCnc { get; set; }
        [UIHint("_NumberAsShort")]
        public int BoxWeight { get; set; }
        [UIHint("_NumberAsShort")]
        public int BoxNumber { get; set; }

        public int LimitColor { get; set; } // 1: red, 2: yellow, 3: orange
        public bool IsLimit { get; set; }
        public double ProductionQuantity { get; set; }
        public double MaterialUsedQuantity { get; set; }
        public double ProductLimitQuantity { get; set; }
        public double MaterialLimitQuantity { get; set; }
        public double MaterialLimitLeft {
            get {
                return MaterialLimitQuantity > MaterialUsedQuantity ? MaterialLimitQuantity - MaterialUsedQuantity : 0;
            }
        }
        public double TotalMaterialInv { get; set; }

        public double KnifeCut { get; set; }
        public double WorkPiece { get; set; }

        public int RunTime { get; set; }
    }
}