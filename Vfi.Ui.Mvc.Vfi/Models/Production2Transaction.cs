using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Production2Transaction
    {
        public Production2Transaction()
        {
            this.Production2TransactionDetail = new List<Production2TransactionDetail>();
        }

        public long TransactionId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string TransactionCode { get; set; }
        public string EoI { get; set; }
        public byte Status { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual ICollection<Production2TransactionDetail> Production2TransactionDetail { get; set; }
    }
}
