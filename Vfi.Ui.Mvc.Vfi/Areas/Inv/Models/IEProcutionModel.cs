using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class IEProcutionModel
    {
        public int ProductId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerCodeName { get; set; }
        public string ProductCode { get; set; }
        public double? EarlyQuantity { get; set; }
        public double? TotalImportQuantity { get; set; }
        public double? TotalExportQuantity { get; set; }
        public double? LastQuantity { get; set; }
    }
}