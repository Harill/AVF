using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SectionLog
    {
        public int LogId { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int ProductionSectionId { get; set; }
        public double NewProductivity { get; set; }
        public double OldProductivity { get; set; }
        public virtual ProductionSection ProductionSection { get; set; }
    }
}
