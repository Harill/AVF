using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class OrderNoteDetail
    {
        public OrderNoteDetail()
        {
            this.InvoiceDetails = new List<InvoiceDetail>();
        }

        public int NoteDetailId { get; set; }
        public Nullable<int> NoteId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<double> Quantity { get; set; }
        public string Note { get; set; }
        public Nullable<double> Weight { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual OrderNote OrderNote { get; set; }
    }
}
