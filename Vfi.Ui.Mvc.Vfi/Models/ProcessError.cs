using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProcessError
    {
        public ProcessError()
        {
            this.ProductInventories = new List<ProductInventory>();
            this.TransactionDetails = new List<TransactionDetail>();
        }

        public int ErrorId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
