using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ToolPeriod
    {
        public long ToolPeriodId { get; set; }
        public int ToolId { get; set; }
        public Nullable<int> PeriodDay { get; set; }
        public Nullable<int> PeriodMonth { get; set; }
        public Nullable<int> PeriodYear { get; set; }
        public Nullable<System.DateTime> PeriodDate { get; set; }
        public Nullable<double> EarlyPeriodQuantity { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> LastPeriodQuantity { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual Tool Tool { get; set; }
    }
}
