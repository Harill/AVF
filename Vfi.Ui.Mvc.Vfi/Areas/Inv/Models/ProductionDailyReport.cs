using System;
using System.Collections.Generic;
using System.Linq;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ProductionDailyReport
    {
        
        public ProductionDailyReport()
        {
            Shifts = new List<Shift>();
            DisplaySum = true;
            PrintCost = 1;
            ShiftA = new Shift();
            ShiftB = new Shift();
            ShiftC = new Shift();
            MachineTypeCost = 0;
            TeamDPrice = 0;
            TechnicalPrice = 0;
        }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int Index { get; set; }
        public bool DisplaySum { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int MaterialInvId { get; set; }
        public string MaterialCode { get; set; }
        public string VendorCode { get; set; }
        public string LotNumber { get; set; }
        public double MaterialWeight { get; set; }
        public double ProductionRate { get; set; }
        public double UnitWeight { get; set; }
        public double UnitPrice { get; set; }
        public int ProductionPrice { get; set; }
        public double ProductionCost { get { return ProductionPrice * TotalShift.Quantity; } }
        public double Productivity { get; set; }
        
        public double ProductivityInShift {
            get {
                if (MachineName.Contains("P")) {
                    return MyUtilities.Product.GetCncProductionRateInFactoryShiftTime(Productivity, ProductionRate);
                }
                return MyUtilities.Product.GetProductionRateInFactoryShiftTime(Productivity);
            }
        }
        public double ProductivityInDay {
            get {
                if (MachineName.Contains("P")) {
                    return MyUtilities.Product.GetCncProductionRateInFactoryDayTime(Productivity, ProductionRate);
                }
                return MyUtilities.Product.GetProductionRateInFactoryDayTime(Productivity);
            }
        }

        public DateTime ReportDate { get; set; }

        public string ReportDateString { get; set; }
        public int ProductivityAlarm { get; set; }
        public int ProductivityAlarm2 { get; set; }

        public double SumProductivity { get { return TotalShift.TotalQuantity > 0 ? ProductivityInDay : 0; } }
        public int CountMachineRun
        {
            get { return TotalShift.TotalQuantity > 0 ? 1 : 0; }
        }

        public string Shift1Name { get; set; }
        public string Shift2Name { get; set; }
        public double ProductUnitPrice { get; set; }
        public int Shift1Count { get; set; }
        public int Shift2Count { get; set; }
        public int PrintCost { get; set; }
        public double ShiftAProductionCostInMonth { get; set; }
        public double ShiftBProductionCostInMonth { get; set; }
        public double ShiftCProductionCostInMonth { get; set; }
        public double ShiftAMateialUse { get; set; }
        public double ShiftBMateialUse { get; set; }
        public double ShiftCMateialUse { get; set; }

        public List<Shift> Shifts { get; set; }
        public Shift TotalShift{
            get
            {
                return new Shift {
                    Quantity = Shifts.Sum(s => s.Quantity),
                    ProcessingQuantity = Shifts.Sum(s => s.ProcessingQuantity),
                    DefectQuantity = Shifts.Sum(s => s.DefectQuantity),
                    MaterialUse = Shifts.Sum(s => s.MaterialUse),
                    ProductionPrice = Shifts.Sum(s => s.ProductionPrice),
                    ProductCost = Shifts.Sum(s => s.ProductCost),
                    ProductCostInMonth = Shifts.Sum(s => s.ProductCostInMonth),
                    MaterialWeight = Shifts.Sum(s => s.MaterialWeight),
                    //ProductionMaterialPlan = Shifts.Sum(s=> s.ProductionMaterialPlan),
                    //MaterialProductionRate = Shifts.Sum(s => s.MaterialProductionRate),
                    NGCost = Shifts.Sum(s => s.NGCost),
                    MaterialDiff = Shifts.Sum(s => s.MaterialDiff),
                    MaterialDiffCost = Shifts.Sum(s => s.MaterialDiffCost),
                    ProductionRate = Shifts.Count > 0 ? Shifts.FirstOrDefault().ProductionRate : 0,

                    DesignProductivity = Shifts.Count > 0 ? Shifts.FirstOrDefault().DesignProductivity : 0,
                };
            }
        }
        public double DifferenceRate { get { return Shifts.Sum(s => s.DifferenceRate); } }
        public Shift ShiftA { get; set; }
        public Shift ShiftB { get; set; }
        public Shift ShiftC { get; set; }

        // for report/SelectProductionTotalReport
        public double DesignProductivity { get; set; }
        public string MachineType { get; set; }
        public double MachineTypeCost { get; set; }
        public double DesignProductivityCost {
            get {
                if (MachineTypeCost > 0) {
                    return MachineTypeCost * DesignProductivity;
                    //if (MachineName.Contains("P")) {
                    //    cost = MachineTypeCost * DesignProductivity;
                    //}
                    //else if (MachineName.Contains("CNC")) {
                    //    cost = MachineTypeCost * DesignProductivity;
                    //}
                    //else if (MachineName.Contains("C")) {
                    //    cost = MachineTypeCost * DesignProductivity;
                    //}
                    //return cost;
                }
                else return 0;

            }
        }
        public double ErrorTimeByRepairForm { get; set; }
        public double ErrorCountByRepairForm { get; set; }

        public int TeamDPrice { get; set; }
        public double TeamDCost { get { return TeamDPrice * TotalShift.Quantity; } }
        public int TechnicalPrice { get; set; }
        public double TechnicalCost { get { return TechnicalPrice * TotalShift.Quantity; } }

        public string MaterialTypeName { get; set; }
        public double MaterialLength { get; set; }
        public double WorkpieceLength { get; set; }

        public double PlanPieceWorkpieceKg {
            get {
                return MaterialLength > 0
                    ? WorkpieceLength / MaterialLength * MaterialWeight * TotalShift.MaterialUse
                    : 0;
            }
        }

    }
    public class Shift
    {
        public Shift()
        {
            Quantity = 0;
            ProcessingQuantity = 0;
            DefectQuantity = 0;
            MaterialUse = 0;
            ProductionPrice = 0;
            ProductCost = 0;
            ProductCostInMonth = 0;
            MaterialWeight = 0;
            ProductionRate = 0;
            ProductivityInShift = 0;
        }
        public DateTime UseDate { get; set; }
        public string ShiftName { get; set; }
        public double MaterialWeight { get; set; }
        public double Quantity { get; set; }
        public double ProcessingQuantity { get; set; }
        public double DefectQuantity { get; set; }
        public double MaterialUse { get; set; }
        public double MaterialUseKg { get { return MaterialUse * MaterialWeight; } }
        public double ProductionPrice { get; set; }
        public double MaterialPrice { get; set; }
        public double DifferenceRate
        {
            get
            {
                return ProductionRate > 0 ?
                    Quantity + ProcessingQuantity + DefectQuantity
                    - ProductionRate * MaterialUse
                    :
                    0;
            }
        }
        public double MaterialDiff { get; set; }
        public double MaterialDiffCost { get; set; }
        public double ProductCost { get; set; }
        public double NGCost { get; set; }
        public double ProductionRate { get; set; }
        public double MaterialProductionRate { get { return MaterialUse * ProductionRate; } }
        public double ProductivityInShift { get; set; }
        public double ProductionMaterialPlan {
            get {
                return ProductionRate > 0 ? 
                    MyUtilities.Function.RoundUp(ProductivityInShift / ProductionRate) :
                    0;
            }
        }
        public double ProductCostInMonth { get; set; }
        // cảnh báo nếu chênh lệch hơn 20%
        public bool Alert
        {
            get
            {
                return ProductionRate > 0 ? (Math.Abs(DifferenceRate) / ProductionRate * MaterialUse) >= 0.2 : false;
            }
        }
        public double TotalQuantity
        {
            get { return Quantity + ProcessingQuantity + DefectQuantity; }
        }
        public int Count { get; set; }

        // for report/SelectProductionTotalReport
        public double NGPercent {
            get {
                return TotalQuantity > 0 ? ((ProcessingQuantity + DefectQuantity) / TotalQuantity * 100) : 0;
            }
        }

        public double DifferenceMaterial {
            get {
                return (ProductionRate > 0 && MaterialUse > 0) ?
                    ((DifferenceRate / ProductionRate) / MaterialUse)
                    :
                    0;
            }
        }
        public double DesignProductivity { get; set; }
        public double RuningTimeByRate {
            get {
                return (TotalQuantity * DesignProductivity) / 3600;
            }
        }
    }
}