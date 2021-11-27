using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class InvoiceDetail
    {
        public long InvoiceDetailId { get; set; }
        public Nullable<long> InvoiceId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public int Piece { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<double> Price { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<long> OrderDetailId { get; set; }
        public Nullable<int> ExportDetailId { get; set; }
        public Nullable<int> NoteDetailId { get; set; }
        public virtual ExportFormTP_KDDetail ExportFormTP_KDDetail { get; set; }
        public virtual Product Product { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
        public virtual OrderNoteDetail OrderNoteDetail { get; set; }
    }
}
