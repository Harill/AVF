using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class TrackingRepairEmployee
    {
        public int TrackingId { get; set; }
        public int RepairEmployeeId { get; set; }
        public int QcEmployeeId { get; set; }
        public System.DateTime StartDate { get; set; }
        public int Status { get; set; }
        public System.DateTime FinishDate { get; set; }
        public int Shift { get; set; }
        public int FixQuantity { get; set; }
        public int MoreTime { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string Note { get; set; }
        public int MachineId { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
    }
}
