using System;
using System.Collections.Generic;
using System.Linq;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {

    public class PrintGroupWorkPiece {
        public string GroupName { get; set; }
        public double PlanWorkPiece { get; set; }
        public double PieceWorkPiece { get; set; }
        public double ScrapWorkPiece { get; set; }
        public double DefectWorkPiece { get; set; }
        public double WorkPieceInMonth { get; set; }
    }

    public class PrintStatisticMaterialType {
        public int Index { get; set; }
        public int VendorId { get; set; }
        public string VendorCode { get; set; }
        public double MaterialUseKg { get; set; }
        public double MaterialUseKgInMonth { get; set; }
        public double Percentage { get; set; }
    }

    public class PrintGroupMaterial {
        public PrintGroupMaterial() {
            List = new List<PrintMaterialDailyPeriod>();
            GroupWorkPiece = new List<PrintGroupWorkPiece>();
            StatisticMaterialTypes = new List<PrintStatisticMaterialType>();
        }
        public double PieceWorkpiece { get; set; }
        public double ScrapWorkpiece { get; set; }
        public List<PrintGroupWorkPiece> GroupWorkPiece { get; set; }

        public double SumPlanWorkPiece { get; set; }
        public double SumPieceWorkPiece { get; set; }
        public double SumScrapWorkPiece { get; set; }
        public double SumDefectWorkPiece { get; set; }
        public double SumWorkPieceInMonth { get; set; }

        public List<PrintStatisticMaterialType> StatisticMaterialTypes { get; set; }
        public double StatisticMaterialUseKg { get; set; }
        public double StatisticMaterialUseKgInMonth { get; set; }

        public int MaterialTyleId { get; set; }
        public string GroupName { get; set; }
        public string Quater { get; set; }
        public List<PrintMaterialDailyPeriod> List { get; set; }

        public double Import {
            get { return List.Sum(l => l.Import); }
        }

        public double ImportKg {
            get { return List.Sum(l => l.ImportKg); }
        }

        public double ImportInMonth {
            get { return List.Sum(l => l.ImportInMonth); }
        }

        public double ImportInMonthKg {
            get { return List.Sum(l => l.ImportInMonthKg); }
        }

        public double Export {
            get { return List.Sum(l => l.Export); }
        }

        public double ExportKg {
            get { return List.Sum(l => l.ExportKg); }
        }

        public double ExportInMonth {
            get { return List.Sum(l => l.ExportInMonth); }
        }

        public double ExportInMonthKg {
            get { return List.Sum(l => l.ExportInMonthKg); }
        }

        public double ExportDestroy {
            get { return List.Sum(l => l.ExportDestroy); }
        }

        public double ExportDestroyInMonth {
            get { return List.Sum(l => l.ExportDestroyInMonth); }
        }

        public double Required {
            get { return List.Sum(l => l.Required); }
        }

        public double RequiredKg {
            get { return List.Sum(l => l.RequiredKg); }
        }

        public double EarlyQuantity { get; set; }
        public double EarlyQuantityKg { get; set; }
        public double LastQuantity { get; set; }
        public double LastQuantityKg { get; set; }
        public double MaterialOnMachine { get; set; }

        public double MaterialUse {
            get { return List.Sum(l => l.MaterialUse); }
        }

        public double MaterialUseKg {
            get { return List.Sum(l => l.MaterialUseKg); }
        }

        public double MaterialUseInMonth {
            get { return List.Sum(l => l.MaterialUseInMonth); }
        }

        public double MaterialUseInMonthKg {
            get { return List.Sum(l => l.MaterialUseInMonthKg); }
        }

        public double ProductQuantity {
            get { return List.Sum(l => l.ProductQuantity); }
        }

        public double ProcessQuantity {
            get { return List.Sum(l => l.ProcessQuantity); }
        }

        public double DefectQuantity {
            get { return List.Sum(l => l.DefectQuantity); }
        }

        public double DefectWeight {
            get { return List.Sum(l => l.DefectWeight); }
        }

        public double ProductQuantityInMonth {
            get { return List.Sum(l => l.ProductQuantityInMonth); }
        }

        public double ProcessQuantityInMonth {
            get { return List.Sum(l => l.ProcessQuantityInMonth); }
        }

        public double DefectQuantityInMonth {
            get { return List.Sum(l => l.DefectQuantityInMonth); }
        }

        public double SmallestMaterialForecasts { get; set; }
        public double ProductivityInDay { get; set; }
        public double MaterialRate { get; set; }

        public double ProductWeight {
            get { return List.Sum(l => l.ProductWeight); }
        }

        public double ProductWeightInMonth {
            get { return List.Sum(l => l.ProductWeightInMonth); }
        }

        public double MaterialWorkPiece {
            get { return MaterialUseKg - ProductWeight; }
        }

        public double MaterialWorkPieceInMonth {
            get { return List.Sum(l => l.MaterialWorkPieceInMonth); }
        }

        public DateTime ReportDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public double DifferentQuantity {
            get { return List.Sum(l => l.DifferentQuantity); }
        }

        public double DifferentQuantityInMonth {
            get { return List.Sum(l => l.DifferentQuantityInMonth); }
        }

        public double WorkPiece { get; set; }
        public double WorkPieceKg { get; set; }


        public double WorkPieceInMonth { get; set; }
        public int CountRow { get; set; }
    }

    public class PrintMaterialDailyPeriod {
        public PrintMaterialDailyPeriod() {
            Details = new List<PrintMaterialDailyPeriodDetail>();
            MaterialUseInDays = new List<MaterialUseInDay>();
        }

        public double MaterialOutDiameter { get; set; }
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public string MaterialDesignNo { get; set; }
        public string Shape { get; set; }
        public double OutDiameter { get; set; }
        public double InDiameter { get; set; }
        public double Length { get; set; }
        public string DiameterType { get; set; }

        public double Import {
            get { return Details.Sum(om => om.Import); }
        }

        public double ImportKg {
            get { return Details.Sum(om => om.ImportKg); }
        }

        public double ImportInMonth {
            get { return Details.Sum(om => om.ImportInMonth); }
        }

        public double ImportInMonthKg {
            get { return Details.Sum(om => om.ImportInMonthKg); }
        }

        public double Export {
            get { return Details.Sum(om => om.Export); }
        }

        public double ExportKg {
            get { return Details.Sum(om => om.ExportKg); }
        }

        public double ExportInMonth {
            get { return Details.Sum(om => om.ExportInMonth); }
        }

        public double ExportInMonthKg {
            get { return Details.Sum(om => om.ExportInMonthKg); }
        }

        public double ExportDestroy {
            get { return Details.Sum(om => om.ExportDestroy); }
        }

        public double ExportDestroyInMonth {
            get { return Details.Sum(om => om.ExportDestroyInMonth); }
        }

        public double LastExport { get; set; }
        public double Required { get; set; }

        public double RequiredKg {
            get { return Details.Sum(om => om.RequiredKg); }
        }

        public double EarlyQuantity { get; set; }
        public double EarlyQuantityKg { get; set; }
        public double LastQuantity { get; set; }
        public double LastQuantityKg { get; set; }
        public double MaterialOnMachine { get; set; }

        public double ProductQuantity {
            get { return Details.Sum(om => om.ProductQuantity); }
        }

        public double ProcessQuantity {
            get { return Details.Sum(om => om.ProcessQuantity); }
        }

        public double DefectQuantity {
            get { return Details.Sum(om => om.DefectQuantity); }
        }

        public double DefectWeight {
            get { return Details.Sum(om => om.DefectWeight); }
        }

        public double ProductWeight {
            get { return Details.Sum(om => om.ProductWeight); }
        }

        public double ProductWeightInMonth {
            get { return Details.Sum(om => om.ProductWeightInMonth); }
        }

        public double MaterialWorkPiece {
            get { return MaterialUseKg - ProductWeight; }
        }

        public double MaterialWorkPieceInMonth {
            get { return MaterialUseInMonthKg - ProductWeightInMonth; }
        }

        public double MaterialForecasts { get; set; }
        public double ProductivityInDay { get; set; }
        public double MaterialRate { get; set; }
        public int MaterialStyle { get; set; }
        public bool Show { get; set; }
        public byte Status { get; set; }
        public byte ForecastStatus { get; set; }

        public double MaterialUse {
            get { return Details.Sum(om => om.MaterialUse); }
        }

        public double MaterialUseKg {
            get { return Details.Sum(om => om.MaterialUseKg); }
        }

        public double MaterialUseInMonth {
            get { return Details.Sum(om => om.MaterialUseInMonth); }
        }

        public double MaterialUseInMonthKg {
            get { return Details.Sum(om => om.MaterialUseInMonthKg); }
        }

        public double ProductQuantityInMonth {
            get { return Details.Sum(om => om.ProductQuantityInMonth); }
        }

        public double ProcessQuantityInMonth {
            get { return Details.Sum(om => om.ProcessQuantityInMonth); }
        }

        public double DefectQuantityInMonth {
            get { return Details.Sum(om => om.DefectQuantityInMonth); }
        }

        public double DifferentQuantity {
            get { return Details.Sum(om => om.DifferentQuantity); }
        }

        public double DifferentQuantityInMonth {
            get { return Details.Sum(om => om.DifferentQuantityInMonth); }
        }

        public List<PrintMaterialDailyPeriodDetail> Details { get; set; }

        public double WorkPieceKg {
            get { return Details.Sum(om => om.WorkPieceKg); }
        }

        public double MaterialUseInPlanKg {
            get { return Details.Sum(om => om.MaterialUseInPlanKg); }
        }

        //public int ExpectDay {
        //    get {
        //        return MaterialUseInPlanKg > 0
        //            ? MyUtilities.Function.RoundDown(LastQuantityKg / MaterialUseInPlanKg)
        //            : -1;
        //    }
        //}

        public int ExpectDay {
            get {
                return MaxMaterialUse > 0
                    ? MyUtilities.Function.RoundDown(LastQuantityKg / MaxMaterialUse)
                    : -1;
            }
        }

        public DateTime ReportDate { get; set; }
        public DateTime PlanDate { get; set; }
        public List<MaterialUseInDay> MaterialUseInDays { get; set; }

        public double MaxMaterialUse {
            get {
                if (!MaterialUseInDays.Any())
                    return 0;
                var max = 0.0;
                var machineIds = MaterialUseInDays.Select(x => x.MachineId).Distinct();
                foreach (var machineId in machineIds) {
                    var canMaterialUseInDays = MaterialUseInDays.Any(x => x.MachineId == machineId && x.DayUse >= PlanDate);
                    if (canMaterialUseInDays) {
                        var newMaterialUseInDays = MaterialUseInDays.Where(x => x.MachineId == machineId).ToList();
                        var lastProductId = newMaterialUseInDays.Last().ProductId;
                        newMaterialUseInDays = newMaterialUseInDays.Where(x => x.ProductId == lastProductId).ToList();
                        max += newMaterialUseInDays.Max(x => x.MaterialUseKg);
                    }
                }
                return max;
            }
        }
    }

    public class MaterialUseInDay {
        public int MachineId { get; set; }
        public int ProductId { get; set; }
        public double MaterialUse { get; set; }
        public double MaterialUseKg { get; set; }
        public DateTime DayUse { get; set; }
    }

    public class MachineExport {
        public int MaterialId { get; set; }
        public int MachineId { get; set; }
        public double LastExport { get; set; }
        public DateTime ExportDate { get; set; }
    }

    public class PrintMaterialDailyPeriodDetail {
        public PrintMaterialDailyPeriodDetail() {
            OnMachines = new List<PrintMaterialDailyPeriodDetailOnMachine>();
        }

        public int ProductId { get; set; }
        public string ProductCode { get; set; }

        public double ProductWeight {
            get { return OnMachines.Sum(om => om.ProductWeight); }
        }

        public double ProductWeightInMonth {
            get { return OnMachines.Sum(om => om.ProductWeightInMonth); }
        }

        public double MaterialWorkPiece {
            get { return MaterialUseKg - ProductWeight; }
        }

        public double MaterialWorkPieceInMonth {
            get { return MaterialUseInMonthKg - ProductWeightInMonth; }
        }

        public double MaterialUse {
            get { return OnMachines.Sum(om => om.MaterialUse); }
        }

        public double MaterialUseKg {
            get { return MaterialUse * MaterialUnitWeight; }
        }


        public double MaterialUseInMonth {
            get { return OnMachines.Sum(om => om.MaterialUseInMonth); }
        }

        public double MaterialUseInMonthKg {
            get { return MaterialUseInMonth * MaterialUnitWeight; }
        }

        public int DayProducted { get; set; }
        public double ProductivityInDay { get; set; }
        public double MaterialRate { get; set; }

        public int MaterialId { get; set; }
        public int MaterialInvId { get; set; }
        public string MaterialLot { get; set; }
        public double MaterialUnitWeight { get; set; }
        public double MaterialLenght { get; set; }
        public double Import { get; set; }

        public double ImportKg {
            get { return Import * MaterialUnitWeight; }
        }

        public double ImportInMonth { get; set; }

        public double ImportInMonthKg {
            get { return ImportInMonth * MaterialUnitWeight; }
        }

        public double Export { get; set; }

        public double ExportKg {
            get { return Export * MaterialUnitWeight; }
        }

        public double ExportInMonth { get; set; }

        public double ExportInMonthKg {
            get { return ExportInMonth * MaterialUnitWeight; }
        }

        public double ExportDestroy { get; set; }
        public double ExportDestroyInMonth { get; set; }
        public double Required { get; set; }

        public double RequiredKg {
            get { return Required * MaterialUnitWeight; }
        }

        public double EarlyQuantity { get; set; }

        public double EarlyQuantityKg {
            get { return EarlyQuantity * MaterialUnitWeight; }
        }

        public double LastQuantity { get; set; }

        public double LastQuantityKg {
            get { return LastQuantity * MaterialUnitWeight; }
        }

        public double MaterialOnMachine { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string Note { get; set; }
        public double LastExport { get; set; }

        public double ProductQuantity {
            get { return OnMachines.Sum(om => om.ProductQuantity); }
        }

        public double ProcessQuantity {
            get { return OnMachines.Sum(om => om.ProcessQuantity); }
        }

        public double DefectQuantity {
            get { return OnMachines.Sum(om => om.DefectQuantity); }
        }

        public double DefectWeight {
            get { return OnMachines.Sum(om => om.DefectWeight); }
        }

        public double ProductQuantityInMonth {
            get { return OnMachines.Sum(om => om.ProductQuantityInMonth); }
        }

        public double ProcessQuantityInMonth {
            get { return OnMachines.Sum(om => om.ProcessQuantityInMonth); }
        }

        public double DefectQuantityInMonth {
            get { return OnMachines.Sum(om => om.DefectQuantityInMonth); }
        }

        public double DifferentQuantity {
            get { return OnMachines.Sum(om => om.DifferentQuantity); }
        }

        public double DifferentQuantityInMonth {
            get { return OnMachines.Sum(om => om.DifferentQuantityInMonth); }
        }

        public int VendorId { get; set; }
        public string VendorCode { get; set; }

        public bool Show {
            get {
                return (ImportInMonth + ExportInMonth + MaterialUseInMonth
                        + ProductQuantityInMonth + ProcessQuantityInMonth + DefectQuantityInMonth
                        > 0 || OnMachines.Any());
            }
        }

        public List<PrintMaterialDailyPeriodDetailOnMachine> OnMachines { get; set; }

        public double WorkPieceKg {
            get { return OnMachines.Sum(om => om.WorkPieceKg); }
        }

        public double MaterialUseInPlanKg {
            get { return OnMachines.Sum(om => om.MaterialUseInPlanKg); }
        }

    }

    public class PrintMaterialDailyPeriodDetailOnMachine {
        public PrintMaterialDailyPeriodDetailOnMachine() {
            Productivity = 0;
            ProductionRate = 0;
        }

        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double ProductQuantity { get; set; }
        public double Productivity { get; set; }
        public double ProcessQuantity { get; set; }
        public double DefectQuantity { get; set; }
        public double ProductQuantityInMonth { get; set; }
        public double ProcessQuantityInMonth { get; set; }
        public double DefectQuantityInMonth { get; set; }
        public double DifferentQuantity { get; set; }
        public double DifferentQuantityInMonth { get; set; }

        public double ProductWeight {
            get { return (ProductQuantity + ProcessQuantity) * ProductUnitWeight / 1000; }
        }

        public double DefectWeight {
            get { return DefectQuantity * ProductUnitWeight / 1000; }
        }

        public double ProductWeightInMonth {
            get { return (ProductQuantityInMonth + ProcessQuantityInMonth) * ProductUnitWeight / 1000; }
        }

        public double ProductUnitWeight { get; set; }
        public double MaterialUnitWeight { get; set; }
        public double ProductionRate { get; set; }

        public double MaterialRate {
            get { return ProductionRate > 0 ? ProductivityInDay / ProductionRate : 0; }
        }

        public double ProductivityInDay {
            get {
                return MyUtilities.Product.GetProductionRateInFactoryDayTime(Productivity);
                //return Productivity > 0 ? MyUtilities.Product.Second20h / Productivity : 0;
            }
        }

        public double MaterialWorkPiece {
            get { return MaterialUseKg - ProductWeight; }
        }

        public double MaterialWorkPieceInMonth {
            get { return MaterialUseInMonthKg - ProductWeightInMonth; }
        }

        public double ProductForecastsQuality { get; set; }
        public double ProductInventory { get; set; }
        public double SaleQuater { get; set; }

        public double MaterialLenght { get; set; }
        public double WorkPieceLenght { get; set; }
        //int WorkPieceLenght = 200;
        public double WorkPieceKg {
            get {
                return (MaterialLenght > 0)
                    ? WorkPieceLenght / MaterialLenght * MaterialUse * MaterialUnitWeight
                    : 0;
            }
        }

        public double MaterialUse { get; set; }
        public double MaterialUseKg {
            get { return MaterialUse * MaterialUnitWeight; }
        }

        public double MaterialUseInPlan { get; set; }
        public double MaterialUseInPlanKg {
            get { return MaterialUseInPlan * MaterialUnitWeight; }
        }

        public double MaterialUseInMonth { get; set; }

        public double MaterialUseInMonthKg {
            get { return MaterialUseInMonth * MaterialUnitWeight; }
        }

        public int DayProducted { get; set; }
        public byte Status { get; set; }
        public double RequiredPerProduct { get; set; }

        public double RequiredPerProductKg {
            get { return RequiredPerProduct * MaterialUnitWeight; }
        }

        public int RequiredStatus { get; set; }
        public int MaterialId { get; set; }
        public int MaterialInvId { get; set; }
        public double Export { get; set; }

        public double ExportKg {
            get { return Export * MaterialUnitWeight; }
        }

        public int MachineId { get; set; }
        public string MachineName { get; set; }

        //public int Day { get; set; }
        //public int Month { get; set; }
        //public int Year { get; set; }
        public double LastExport { get; set; }
        public double ExportInMonth { get; set; }

        public double ExportInMonthKg {
            get { return ExportInMonth * MaterialUnitWeight; }
        }

        public double Performance {
            get { return ProductivityInDay > 0 ? ProductQuantity / ProductivityInDay * 100 : 0; }
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public double ProductOrder { get; set; }
        public byte OrderStatus { get; set; }
        public int ProductionMaterialStatus { get; set; }
    }
}