using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Production2TransactionDetail
    {
        public long DetailId { get; set; }
        public long TransactionId { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public double QuantityKg { get; set; }
        public string UnitMeasure { get; set; }
        public string Note { get; set; }
        public Nullable<int> SectionIssueId { get; set; }
        public Nullable<int> SectionReceiptId { get; set; }
        public Nullable<int> MachineId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public double QuantityDefect { get; set; }
        public double Time { get; set; }
        public double OverTime { get; set; }
        public int SectionIndex { get; set; }
        public double QuantityLost { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual Production2Transaction Production2Transaction { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductionSection ProductionSection { get; set; }
        public virtual ProductionSection ProductionSection1 { get; set; }
    }
}
