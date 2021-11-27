using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class PrintMaterialDailyReportModel
    {
        public int MaterialId { get; set; }
        public int MaterialInvId { get; set; }
        public int MaterialTypeId { get; set; }
        public string VendorCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialCode { get; set; }
        public double OutDiameter { get; set; }
        public double InDiameter { get; set; }
        public string Shape { get; set; }
        public string DiameterType { get; set; }
        public double Length { get; set; }
        public string DesignNo { get; set; }
        public string MaterialLot { get; set; }
        public double MaterialWeight { get; set; }
       
        public double MaterialUse { get; set; }
        public double MaterialUseInMonth { get; set; }
        public double MaterialUseKg { get; set; }
        public double MaterialUseInMonthKg { get; set; }

        public double Production { get; set; }
        public double ProductionKg { get; set; }
        public double ProductionInMonth { get; set; }
        public double ProductionInMonthKg { get; set; }
        public double DefectProduction { get; set; }
        public double DefectProductionKg { get; set; }
        public double DefectProductionInMonth { get; set; }
        public double DefectProductionInMonthKg { get; set; }
        public double TotalProduction { get; set; }
        public double TotalProductionKg { get; set; }
        public double TotalProductionInMonth { get; set; }
        public double TotalProductionInMonthKg { get; set; }
        public double DifferenceStandard { get; set; }
        public double DifferenceStandardInMonth { get; set; }

        public double WorkpieceMaterial { get; set; }
        public double WorkpieceMaterialInMonth { get; set; }
        public List<PrintMaterialDailyDetailReportModel> Details { get; set; }
    }
    public class PrintMaterialDailyDetailReportModel
    {
        public int MaterialId { get; set; }
        public int MaterialInvId { get; set; }
        public int MaterialTypeId { get; set; }
        public double MaterialUse { get; set; }
        public double MaterialUseInMonth { get; set; }
        public double MaterialUseKg { get; set; }
        public double MaterialUseInMonthKg { get; set; }

        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double ProductWeight { get; set; }
        public double Production { get; set; }
        public double ProductionKg { get; set; }
        public double ProductionInMonth { get; set; }
        public double ProductionInMonthKg { get; set; }
        public double DefectProduction { get; set; }
        public double DefectProductionKg { get; set; }
        public double DefectProductionInMonth { get; set; }
        public double DefectProductionInMonthKg { get; set; }
        public double TotalProduction { get; set; }
        public double TotalProductionKg { get; set; }
        public double TotalProductionInMonth { get; set; }
        public double TotalProductionInMonthKg { get; set; }
        public double ProductionRate { get; set; }
        public double StandardProduction { get; set; }
        public double DifferenceStandard { get; set; }
        public double DifferenceStandardInMonth { get; set; }

        public double WorkpieceMaterial { get; set; }
        public double WorkpieceMaterialInMonth { get; set; }
        public string MachineName { get; set; }
        public int MachineId { get; set; }
    }
    public class PrintMaterialGroupDailyReportModel
    {
        public DateTime ReportDate { get; set; }
        public string StartDate { get; set; }
        public List<PrintMaterialDailyReportModel> List { get; set; }
        public int MaterialTypeId { get; set; }
        public string GroupName { get; set; }
        public string IdentityCode { get; set; }
        public double WorkPiece { get; set; }
        
        public double MaterialUse { get; set; }
        public double MaterialUseInMonth { get; set; }
        public double MaterialUseKg { get; set; }
        public double MaterialUseInMonthKg { get; set; }

        public double Production { get; set; }
        public double ProductionKg { get; set; }
        public double ProductionInMonth { get; set; }
        public double ProductionInMonthKg { get; set; }
        public double DefectProduction { get; set; }
        public double DefectProductionKg { get; set; }
        public double DefectProductionInMonth { get; set; }
        public double DefectProductionInMonthKg { get; set; }
        public double TotalProduction { get; set; }
        public double TotalProductionKg { get; set; }
        public double TotalProductionInMonth { get; set; }
        public double TotalProductionInMonthKg { get; set; }
        public double DifferenceStandard { get; set; }
        public double DifferenceStandardInMonth { get; set; }

        public double WorkpieceMaterial { get; set; }
        public double WorkpieceMaterialInMonth { get; set; }
        
    }
}