using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ExportTool
    {
        public ExportTool()
        {
            this.ExportToolDetails = new List<ExportToolDetail>();
        }

        public long ExportId { get; set; }
        public Nullable<long> TransactionId { get; set; }
        public Nullable<System.DateTime> ExportDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<int> MachineId { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public Nullable<int> ProductId { get; set; }
        public virtual TransactionFpt TransactionFpt { get; set; }
        public virtual ICollection<ExportToolDetail> ExportToolDetails { get; set; }
    }
}
