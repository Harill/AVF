using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class OrderNote
    {
        public OrderNote()
        {
            this.ExportChangeProducts = new List<ExportChangeProduct>();
            this.OrderNoteDetails = new List<OrderNoteDetail>();
        }

        public int NoteId { get; set; }
        public string NoteNumber { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<byte> NoteType { get; set; }
        public Nullable<long> InvoiceId { get; set; }
        public Nullable<long> TransactionId { get; set; }
        public Nullable<int> ExportId { get; set; }
        public Nullable<bool> IsComplete { get; set; }
        public virtual ICollection<ExportChangeProduct> ExportChangeProducts { get; set; }
        public virtual ExportFormTP_KD ExportFormTP_KD { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual ICollection<OrderNoteDetail> OrderNoteDetails { get; set; }
    }
}
