using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ProductionDefectDailyModel
    {
        public int Index{ get; set; }
        public DateTime ReportDate { get; set; }
        public string ProductCode { get; set; }
        public double FromSx1Quantity { get; set; }
        public double FromSx2Quantity { get; set; }
        public double FromCncQuantity { get; set; }
        public double FromQcQuantity { get; set; }
        public double FromProcessingQuantity { get; set; }
        public double FromTotal { get; set; }
        public double FromSx1QuantityInMonth { get; set; }
        public double FromSx2QuantityInMonth { get; set; }
        public double FromCncQuantityInMonth { get; set; }
        public double FromQcQuantityInMonth { get; set; }
        public double FromProcessingQuantityInMonth { get; set; }
        public double FromTotalInMonth { get; set; }

    }
}