using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SectionProcessTransactionDetail
    {
        public SectionProcessTransactionDetail()
        {
            this.SectionProcessPeriods = new List<SectionProcessPeriod>();
        }

        public int DetailId { get; set; }
        public int TransactionId { get; set; }
        public int FromProcessId { get; set; }
        public int ToProcessId { get; set; }
        public double ProcessQuantity { get; set; }
        public double DefectQuantity { get; set; }
        public double UnitWeight { get; set; }
        public Nullable<int> MachineId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public double Time { get; set; }
        public double Overtime { get; set; }
        public virtual SectionProcess SectionProcess { get; set; }
        public virtual SectionProcess SectionProcess1 { get; set; }
        public virtual ICollection<SectionProcessPeriod> SectionProcessPeriods { get; set; }
        public virtual SectionProcessTransaction SectionProcessTransaction { get; set; }
    }
}
