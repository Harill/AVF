using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ExportFormQC_TP
    {
        public ExportFormQC_TP()
        {
            this.ExportFormQC_TPDetail = new List<ExportFormQC_TPDetail>();
        }

        public int ExportId { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string TransactionCode { get; set; }
        public virtual ICollection<ExportFormQC_TPDetail> ExportFormQC_TPDetail { get; set; }
    }
}
