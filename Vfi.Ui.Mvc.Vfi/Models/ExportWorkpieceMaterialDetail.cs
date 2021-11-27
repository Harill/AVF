using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ExportWorkpieceMaterialDetail
    {
        public int DetailId { get; set; }
        public Nullable<int> ExportId { get; set; }
        public string IdentityCode { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public string Note { get; set; }
        public virtual ExportWorkpieceMaterial ExportWorkpieceMaterial { get; set; }
    }
}
