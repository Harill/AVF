using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class ResourcesReportModel {
        public string Month { get; set; }

        public double MaterialUse { get; set; }
        public double MaterialUsePrice { get; set; }

        public double ProductionRate { get; set; }
        public double ProductionQuantity { get; set; }
        public double ProductionQuantityMax { get; set; }
        public double ProductionPrice { get; set; }

        public double ProductionCNC { get; set; }
        public double ProductionCNCPrice { get; set; }
        public double Production2 { get; set; }
        public double Production2Price { get; set; }


        public double ToolExport { get; set; }
        public double ToolExportPrice { get; set; }

        public double FuelExport { get; set; }
        public double FuelExportPrice { get; set; }

        public double ProductExport { get; set; }
        public double ProductExportPrice { get; set; }

        public double TotalUsePrice { get { return MaterialUsePrice + ToolExportPrice + FuelExportPrice; } }
        public double TotalProductionPrice { get { return ProductionPrice + ProductionCNCPrice + Production2Price; } }
    }
}