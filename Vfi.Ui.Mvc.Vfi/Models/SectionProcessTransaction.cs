using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SectionProcessTransaction
    {
        public SectionProcessTransaction()
        {
            this.SectionProcessPeriods = new List<SectionProcessPeriod>();
            this.SectionProcessTransactionDetails = new List<SectionProcessTransactionDetail>();
        }

        public int TransactionId { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string TransactionCode { get; set; }
        public byte Type { get; set; }
        public byte Status { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual ICollection<SectionProcessPeriod> SectionProcessPeriods { get; set; }
        public virtual ICollection<SectionProcessTransactionDetail> SectionProcessTransactionDetails { get; set; }
    }
}
