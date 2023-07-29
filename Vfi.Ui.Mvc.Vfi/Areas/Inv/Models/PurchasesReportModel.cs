using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class PurchasesReportModel {
        public string Month { get; set; }

        public double PurchasesQuantity { get; set; }
        public double PurchasesPrice { get; set; }

        public int ImportCount { get { return ImportMaterialCount + ImportFuelCount + ImportToolCount + ImportProductCount; } }
        public double ImportQuantity { get { return ImportMaterial + ImportFuel + ImportTool + ImportProduct; } }

        public int ImportMaterialCount { get; set; }
        public double ImportMaterial { get; set; }
        public int ImportFuelCount { get; set; }
        public double ImportFuel { get; set; }
        public int ImportToolCount { get; set; }
        public double ImportTool { get; set; }
        public int ImportProductCount { get; set; }
        public double ImportProduct { get; set; }

    }
}