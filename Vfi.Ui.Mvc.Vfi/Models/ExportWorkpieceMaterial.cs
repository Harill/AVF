using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ExportWorkpieceMaterial
    {
        public ExportWorkpieceMaterial()
        {
            this.WorkpieceMaterialPeriods = new List<WorkpieceMaterialPeriod>();
            this.ExportWorkpieceMaterialDetails = new List<ExportWorkpieceMaterialDetail>();
        }

        public int ExportId { get; set; }
        public Nullable<System.DateTime> ExportDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual ICollection<WorkpieceMaterialPeriod> WorkpieceMaterialPeriods { get; set; }
        public virtual ICollection<ExportWorkpieceMaterialDetail> ExportWorkpieceMaterialDetails { get; set; }
    }
}
