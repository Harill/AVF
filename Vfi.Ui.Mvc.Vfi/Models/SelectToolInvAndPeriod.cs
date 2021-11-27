using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SelectToolInvAndPeriod
    {
        public int ToolInvId { get; set; }
        public int ToolId { get; set; }
        public string ToolFullCode { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public double TotalQuantity { get; set; }
        public string LotNumber { get; set; }
        public Nullable<double> PeriodQuantity { get; set; }
    }
}
