using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class InvoiceDetail
    {
        public long InvoiceDetailId { get; set; }
        public Nullable<long> InvoiceId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> ProductDespatchNoteId { get; set; }
        public Nullable<double> ProductLength { get; set; }
        public Nullable<int> Bundle { get; set; }
        public Nullable<int> Piece { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<double> VatAmount { get; set; }
        public Nullable<double> TotalAmount { get; set; }
        public Nullable<int> RemainedBundle { get; set; }
        public Nullable<double> RemainedWeight { get; set; }
        public Nullable<int> RemainedPiece { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
