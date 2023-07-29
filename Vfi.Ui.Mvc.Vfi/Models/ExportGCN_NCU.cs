using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ExportGCN_NCU
    {
        public ExportGCN_NCU()
        {
            this.ExportGCN_NCUDetail = new List<ExportGCN_NCUDetail>();
        }

        public int ExportId { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<int> BoxNumber { get; set; }
        public Nullable<int> BlockNumber { get; set; }
        public string TransactionCode { get; set; }
        public string ProviderName { get; set; }
        public Nullable<System.DateTime> ExportDate { get; set; }
        public Nullable<int> PlatingFormId { get; set; }
        public Nullable<long> TransactionId { get; set; }
        public Nullable<bool> IsWorkOrder { get; set; }
        public virtual PlatingForm PlatingForm { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual ICollection<ExportGCN_NCUDetail> ExportGCN_NCUDetail { get; set; }
    }
}
