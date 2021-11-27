using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ImportWorkpieceMaterial
    {
        public ImportWorkpieceMaterial()
        {
            this.WorkpieceMaterialPeriods = new List<WorkpieceMaterialPeriod>();
            this.ImportWorkpieceMaterialDetails = new List<ImportWorkpieceMaterialDetail>();
        }

        public int ImportId { get; set; }
        public Nullable<int> ImportSx1Id { get; set; }
        public Nullable<long> TransactionId { get; set; }
        public Nullable<System.DateTime> ImportDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<WorkpieceMaterialPeriod> WorkpieceMaterialPeriods { get; set; }
        public virtual ImportFormSX1 ImportFormSX1 { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual ICollection<ImportWorkpieceMaterialDetail> ImportWorkpieceMaterialDetails { get; set; }
    }
}
