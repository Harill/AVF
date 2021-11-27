using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ExportChangeProduct
    {
        public int ExportChangeId { get; set; }
        public Nullable<int> NoteId { get; set; }
        public Nullable<long> TransactionId { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ExportDate { get; set; }
        public string Transporter { get; set; }
        public string CompanyTransport { get; set; }
        public string CarNumber { get; set; }
        public Nullable<int> Totalbox { get; set; }
        public virtual OrderNote OrderNote { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
