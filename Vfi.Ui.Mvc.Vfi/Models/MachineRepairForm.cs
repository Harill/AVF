using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MachineRepairForm
    {
        public MachineRepairForm()
        {
            this.RepairFormDetails = new List<RepairFormDetail>();
        }

        public int FormId { get; set; }
        public int MachineId { get; set; }
        public int ProductId { get; set; }
        public int StateId { get; set; }
        public string ErrorCause { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public string StartUser { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> FinishDate { get; set; }
        public string FinishUser { get; set; }
        public Nullable<int> FixId { get; set; }
        public string Note { get; set; }
        public int Shift { get; set; }
        public int MoreTime { get; set; }
        public Nullable<int> SectionId { get; set; }
        public System.DateTime CauseDate { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public Nullable<int> ErrorQuantity { get; set; }
        public Nullable<int> ErrorCauseId { get; set; }
        public virtual ErrorCauseForm ErrorCauseForm { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual MachineState MachineState { get; set; }
        public virtual MachineStateDetail MachineStateDetail { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductionSection ProductionSection { get; set; }
        public virtual ICollection<RepairFormDetail> RepairFormDetails { get; set; }
    }
}
