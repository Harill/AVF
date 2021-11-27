using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class TaxInvoiceDetail
    {
        public int Id { get; set; }
        public Nullable<int> TaxInvoiceId { get; set; }
        public Nullable<double> Money { get; set; }
        public Nullable<int> Times { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string Note { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<System.DateTime> ImportDate { get; set; }
        public virtual TaxInvoice TaxInvoice { get; set; }
    }
}
