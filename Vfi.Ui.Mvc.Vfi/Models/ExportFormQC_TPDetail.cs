using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ExportFormQC_TPDetail
    {
        public int DetailId { get; set; }
        public Nullable<int> ExportId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Box { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<double> Number { get; set; }
        public string Note { get; set; }
        public virtual ExportFormQC_TP ExportFormQC_TP { get; set; }
        public virtual Product Product { get; set; }
    }
}
