using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionSectionProcess
    {
        public int PSPId { get; set; }
        public int ProcessId { get; set; }
        public int NextProcessId { get; set; }
        public double Productivity { get; set; }
        public double UnitWeight { get; set; }
        public double UnitPrice { get; set; }
        public string UnitMeasure { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public bool Active { get; set; }
        public virtual SectionProcess SectionProcess { get; set; }
        public virtual SectionProcess SectionProcess1 { get; set; }
    }
}
