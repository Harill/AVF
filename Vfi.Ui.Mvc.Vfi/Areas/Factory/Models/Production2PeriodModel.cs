using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class Production2PeriodModel
    {
        public long PeriodId { get; set; }
        public long TransactionId { get; set; }
        public int InvId { get; set; }
        public System.DateTime PeriodDate { get; set; }
        public double EarlyQuantity { get; set; }
        public double Quantity { get; set; }

        public double Import { get; set; }
        public double ImportPeriod { get; set; }
        public double Export { get; set; }
        public double ExportDefect { get; set; }
        public double ExportLost { get; set; }
        public double ExportPeriod { get; set; }
        public double SectionProductivity { get; set; }
        public double LastQuantity { get; set; }
        public double Weight { get; set; }
        public int GlobalIndex { get; set; }
        public double Time { get; set; }
        public double OverTime { get; set; }
        public int SectionIndex { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int SectionId { get; set; }
        public string SectionName { get; set; }
    }
}