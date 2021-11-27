using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ImportWorkpieceMaterialDetail
    {
        public int DetailId { get; set; }
        public Nullable<int> ImportId { get; set; }
        public string IdentityCode { get; set; }
        public Nullable<double> Weight { get; set; }
        public string Note { get; set; }
        public virtual ImportWorkpieceMaterial ImportWorkpieceMaterial { get; set; }
    }
}
