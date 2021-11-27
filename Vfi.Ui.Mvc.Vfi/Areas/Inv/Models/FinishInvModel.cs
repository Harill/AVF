using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class FinishInvModel
    {
        public int GlobalIndex { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }

        public double Weight { get; set; }

        public double EarlyInventory { get; set; }
        public double EarlyInventoryKg { get; set; }
        public double ImportQc { get; set; }
        public double ImportQcInMonth { get; set; }

        public double ExportCxl { get; set; }
        public double ExportCxlInMonth { get; set; }
        public double ExportKd { get; set; }
        public double ExportKdInMonth { get; set; }
        public double TotalExport { get; set; }

        public double LastInventory { get; set; }
        public double LastInventoryKg { get; set; }
    }
}