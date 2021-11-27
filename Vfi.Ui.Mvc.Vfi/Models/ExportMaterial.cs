using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ExportMaterial
    {
        public ExportMaterial()
        {
            this.ExportMaterialDetails = new List<ExportMaterialDetail>();
        }

        public long ExportId { get; set; }
        public Nullable<long> TransactionId { get; set; }
        public System.DateTime ExportDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string ShiftName { get; set; }
        public Nullable<byte> ShiftType { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual ICollection<ExportMaterialDetail> ExportMaterialDetails { get; set; }
    }
}
