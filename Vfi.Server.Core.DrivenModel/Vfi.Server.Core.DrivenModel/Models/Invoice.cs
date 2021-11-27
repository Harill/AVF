using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceDetails = new List<InvoiceDetail>();
        }

        public long InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public Nullable<int> PriceListId { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
