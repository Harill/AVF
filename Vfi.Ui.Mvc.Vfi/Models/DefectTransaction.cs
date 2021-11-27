using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class DefectTransaction
    {
        public DefectTransaction()
        {
            this.DefectInventoryPeriods = new List<DefectInventoryPeriod>();
            this.DefectTransactionDetails = new List<DefectTransactionDetail>();
        }

        public long TransactionId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string TransactionCode { get; set; }
        public byte Status { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<long> ImportTransactionId { get; set; }
        public byte EoI { get; set; }
        public virtual ICollection<DefectInventoryPeriod> DefectInventoryPeriods { get; set; }
        public virtual ICollection<DefectTransactionDetail> DefectTransactionDetails { get; set; }
    }
}
