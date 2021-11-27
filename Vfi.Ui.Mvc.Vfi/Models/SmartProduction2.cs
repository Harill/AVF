using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SmartProduction2
    {
        public int SmartId { get; set; }
        public int MachineId { get; set; }
        public int EmployeeId { get; set; }
        public int ProductId { get; set; }
        public int SectionIssueId { get; set; }
        public Nullable<int> SectionReceiptId { get; set; }
        public double QuantityKg { get; set; }
        public double Time { get; set; }
        public bool Active { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual ProductionSection ProductionSection { get; set; }
        public virtual ProductionSection ProductionSection1 { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Product Product { get; set; }
    }
}
