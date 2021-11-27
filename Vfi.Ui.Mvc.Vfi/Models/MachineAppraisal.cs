using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MachineAppraisal
    {
        public long AppraisalId { get; set; }
        public Nullable<int> WarehouseId { get; set; }
        public Nullable<int> MachineId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> AppraisalTime { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
