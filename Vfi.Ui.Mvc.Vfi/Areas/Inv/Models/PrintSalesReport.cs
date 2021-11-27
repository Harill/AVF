using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class PrintSalesReport {
        public PrintSalesReport() {
            List = new List<SalesReport>();
            Productivity = 0;
            Productivity2 = 0;
            Section = 0;
        }

        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }

        public string MaterialCode { get; set; }

        public string ProductDesign { get; set; }
        public double ProductMaterialWeight { get; set; }
        public double ProductionRate { get; set; }
        public double Productivity { get; set; }
        public int Section { get; set; }
        public double Productivity2 { get; set; }

        public double ProductivityInDay {
            get {
                return MyUtilities.Product.GetProductionRateInFactoryDayTime(Productivity);
                //return Productivity > 0 ? MyUtilities.Product.Second20h / Productivity : 0;
            }
        }
        public double Productivity2InDay {
            get {
                return MyUtilities.Product.GetProductionRateInDayTime(Productivity2);
                //return Productivity2 > 0 ? MyUtilities.Product.Second7_5h / Productivity2 : 0;
            }
        }

        public DateTime ReportDate { get; set; }
        public List<SalesReport> List { get; set; }

        public double OrderQuantity { get { return List.Sum(l => l.OrderQuantity); } }
        public double ExportQuantity { get { return List.Sum(l => l.ExportQuantity); } }
        public double ProductionQuantity { get { return List.Sum(l => l.ProductionQuantity); } }
        public double ForecastQuantity { get { return List.Sum(l => l.ForecastQuantity); } }
    }

    public class SalesReport {
        public SalesReport() {
            Month = 0;
            OrderQuantity = 0;
            ExportQuantity = 0;
            ProductionQuantity = 0;
        }
        public int Month { get; set; }
        public double OrderQuantity { get; set; }
        public double ExportQuantity { get; set; }
        public double ProductionQuantity { get; set; }
        public double ForecastQuantity { get; set; }
    }
}