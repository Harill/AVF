using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class WorkpieceMaterialPeriod
    {
        public long PeriodId { get; set; }
        public string IdentityCode { get; set; }
        public int Type { get; set; }
        public double Weight { get; set; }
        public string Note { get; set; }
        public Nullable<int> EoIId { get; set; }
        public int EoI { get; set; }
        public System.DateTime PeriodDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public double EarlyQuantity { get; set; }
        public double LastQuantity { get; set; }
        public bool IsDestroy { get; set; }
        public Nullable<byte> ExportType { get; set; }
        public virtual ExportWorkpieceMaterial ExportWorkpieceMaterial { get; set; }
        public virtual ImportWorkpieceMaterial ImportWorkpieceMaterial { get; set; }
    }
}
