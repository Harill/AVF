using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class DefectInvModel
    {
        public int GlobalIndex { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }

        public double Weight { get; set; }

        public double EarlyInventory { get; set; }
        public double EarlyInventoryKg { get; set; }
        public double ImportSx1 { get; set; }
        public double ImportSx1InMonth { get; set; }
        public double ImportCxl1 { get; set; }
        public double ImportCxl1InMonth { get; set; }
        public double ImportCxl2 { get; set; }
        public double ImportCxl2InMonth { get; set; }
        public double TotalImport { get; set; }
        public double LastInventory { get; set; }
        public double LastInventoryKg { get; set; }


    }
}