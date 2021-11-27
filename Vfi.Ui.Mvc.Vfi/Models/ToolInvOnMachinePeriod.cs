using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ToolInvOnMachinePeriod
    {
        public int PeriodId { get; set; }
        public int ToolInvMachineId { get; set; }
        public System.DateTime PeriodDate { get; set; }
        public double EarlyQuantity { get; set; }
        public double Quantity { get; set; }
        public double LastQuantity { get; set; }
        public string Note { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<int> UseId { get; set; }
        public Nullable<long> TransactionId { get; set; }
        public virtual ToolInvOnMachine ToolInvOnMachine { get; set; }
        public virtual ToolUse ToolUse { get; set; }
        public virtual TransactionFpt TransactionFpt { get; set; }
    }
}
