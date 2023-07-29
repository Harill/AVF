using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class SalesReportModel {
        public string Month { get; set; }

        public double OrderQuantity { get; set; }
        public double OrderPrice { get; set; }
        public int OrderProductCount { get; set; }
        public int OrderLateCount { get; set; }

        public double ForecastQuantity { get; set; }

        public double ExportQuantity { get; set; }
        public double ExportPrice { get; set; }

        public double ReturnCount { get; set; }
        public double ReturnQuantity { get; set; }
    }
}