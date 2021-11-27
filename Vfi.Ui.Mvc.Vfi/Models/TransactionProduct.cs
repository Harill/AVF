using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class TransactionProduct
    {
        public TransactionProduct()
        {
            this.TransactionDetails = new List<TransactionDetail>();
        }

        public long DetailId { get; set; }
        public long TransactionId { get; set; }
        public string Note { get; set; }
        public double Quantity { get; set; }
        public double QuantityKg { get; set; }
        public int ProductId { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
        public virtual Product Product { get; set; }
    }
}
