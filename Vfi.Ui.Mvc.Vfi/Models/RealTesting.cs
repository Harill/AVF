using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class RealTesting
    {
        public int RealTestId { get; set; }
        public int ReferenceTestingDetailId { get; set; }
        public int Idx { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int ProductionMachineId { get; set; }
        public System.DateTime ProductionDate { get; set; }
        public System.DateTime TestDate { get; set; }
        public int TestEmployeeId { get; set; }
        public Nullable<int> MachineTypeId { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public double TestNumber { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int FromWarehouseId { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual ProcessingType ProcessingType { get; set; }
        public virtual ProductionTestingDetail ProductionTestingDetail { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Warehouse Warehouse1 { get; set; }
    }
}
