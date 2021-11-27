using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class TaxInvoiceProductDetail
    {
        public long PDetailId { get; set; }
        public Nullable<int> ExportDetailId { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public Nullable<int> TaxInvoiceId { get; set; }
        public Nullable<System.DateTime> ExportDate { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<bool> Active { get; set; }
        public virtual ExportFormTP_KDDetail ExportFormTP_KDDetail { get; set; }
        public virtual TaxInvoice TaxInvoice { get; set; }
    }
}
