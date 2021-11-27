using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SectionProcessPeriod
    {
        public int PeriodId { get; set; }
        public System.DateTime PeriodDate { get; set; }
        public int TransactionId { get; set; }
        public int TransactionDetailId { get; set; }
        public int ProcessId { get; set; }
        public int ProcessInvId { get; set; }
        public double EarlyQuantity { get; set; }
        public double Quantity { get; set; }
        public double LastQuantity { get; set; }
        public virtual SectionProcessInventory SectionProcessInventory { get; set; }
        public virtual SectionProcessTransaction SectionProcessTransaction { get; set; }
        public virtual SectionProcessTransactionDetail SectionProcessTransactionDetail { get; set; }
    }
}
