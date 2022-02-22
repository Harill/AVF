using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class ProductionNGReportModel {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string CustomerCode { get; set; }
        public double UnitPrice { get; set; }

        public double Production1Reprocess { get; set; }
        public double Production1Defect { get; set; }

        public double CNCReprocess { get; set; }
        public double CNCDefect { get; set; }

        public double Production2Reprocess { get; set; }
        public double Production2Defect { get; set; }

        public double Reprocess { get { return TotalReprocess - Production1Reprocess - CNCReprocess - Production2Reprocess; } }
        public double Defect { get { return TotalDefect - Production1Defect - CNCDefect - Production2Defect; } }

        public double TotalReprocess { get; set; }
        public double TotalDefect { get; set; }

    }
}