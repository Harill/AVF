using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class PrintAllProductModel
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string CustomerProductCode { get; set; }
        public string ProductName { get; set; }
        public int Index { get; set; }
        public double UnitPrice { get; set; }
        public double EarlyQuantity { get; set; }
        public double EarlyPrice { get; set; }
        public double ImportQuantity { get; set; }
        public double ImportPrice { get; set; }
        public double ExportFinishQuantity { get; set; }
        public double ExportDefectQuantity { get; set; }
        public double ExportQuantity { get; set; }
        public double ExportPrice { get; set; }
        public double LastQuantity { get; set; }
        public double LastPrice { get; set; }
}
    public class PrintAllProductGroupModel
    {
        public int Index { get; set; }
        public int CustomerId { get; set; }
        public string CutomerCode { get; set; }
        public string CustomerName { get; set; }

        public double TotalEarlyQuantity { get; set; }
        public double TotalEarlyPrice { get; set; }
        public double TotalImportQuantity { get; set; }
        public double TotalImportPrice { get; set; }
        public double TotalExportFinishQuantity { get; set; }
        public double TotalExportDefectQuantity { get; set; }
        public double TotalExportQuantity { get; set; }
        public double TotalExportPrice { get; set; }
        public double TotalLastQuantity { get; set; }
        public double TotalLastPrice { get; set; }
    }
}