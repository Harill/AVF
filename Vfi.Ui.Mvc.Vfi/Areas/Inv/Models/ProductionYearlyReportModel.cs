using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class ProductionYearlyReportModel {
        public string Month { get; set; }

        public double ProductionQuantityMax { get; set; }
        public double ProductionQuantityLossRate {
            get {
                return ProductionQuantityMax > 0 ? (1 - ProductionQuantityTotal / ProductionQuantityMax) * 100 : 0;
            }
        }

        public double ProductionQuantity { get; set; }

        public double NGQuantity { get; set; }
        public double DefectQuantity { get; set; }
        public double NGDefectQuantity { get { return NGQuantity + DefectQuantity; } }
        public double ProductionQuantityTotal { get { return ProductionQuantity + NGQuantity + DefectQuantity; } }
        public double NGPercent {
            get {
                return ProductionQuantity > 0 ? NGDefectQuantity / ProductionQuantityTotal * 100 : 0;
            }
        }

        public double NGQuantityAfter { get; set; }
        public double DefectQuantityAfter { get; set; }
        public double NGDefectQuantityAfter { get { return NGQuantityAfter + DefectQuantityAfter; } }
        public double NGAfterPercent {
            get {
                return ProductionQuantity > 0 ? NGDefectQuantityAfter / (ProductionQuantity) * 100 : 0;
            }
        }

        public double ExportQuantity { get; set; }
        public double ReturnQuantity { get; set; }
    }
}