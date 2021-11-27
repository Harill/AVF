using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ProductionMonthlyReport
    {
        public ProductionMonthlyReport()
        {
            Shifts = new List<Shift>();
            Production = new[]
                {
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0
                };
            Defect = new[]
                {
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0
                };
            ProductionCost = new[]
                {
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0
                };
        }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int MachineId { get;set;}
        public  string MachineName { get; set; }
        public int MaterialInvId { get; set; }
        public string MaterialInvCode { get; set; }

        public double[] Production { get; set; }
        public double[] Defect { get; set; }
        public double[] ProductionCost { get; set; }
        public double[] MaterialUse { get; set; }
        public string[] ProductionDate { get; set; }
        public List<Shift> Shifts { get; set; }
        public double TotalProduction { get; set; }
        public double TotalDefect { get; set; }
        public double TotalDefectCost { get; set; }
        public double TotalProductionCost { get; set; }
        public string Shift { get; set; }
        public double SalePrice { get; set; }
        public DateTime ReportDate { get; set; }
        public string ProductionLot { get; set; }
        public double ProductWeight { get; set; }
    }
}