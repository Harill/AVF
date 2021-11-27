using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ExportFormTP_KD
    {
        public ExportFormTP_KD()
        {
            this.ExportFormTP_KDDetail = new List<ExportFormTP_KDDetail>();
            this.Invoices = new List<Invoice>();
            this.OrderNotes = new List<OrderNote>();
        }

        public int ExportId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string Transporter { get; set; }
        public string CompanyTransporter { get; set; }
        public string CarNumber { get; set; }
        public Nullable<System.DateTime> DateTransporter { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public string TransactionCode { get; set; }
        public Nullable<int> TotalBox { get; set; }
        public Nullable<long> OrderId { get; set; }
        public Nullable<bool> CreatedInvoice { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<ExportFormTP_KDDetail> ExportFormTP_KDDetail { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<OrderNote> OrderNotes { get; set; }
    }
}
