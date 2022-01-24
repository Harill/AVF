using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionTestingMachine
    {
        public int TestingToolId { get; set; }
        public int TestingDetailId { get; set; }
        public int Idx { get; set; }
        public int MachineTypeId { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual ProcessingType ProcessingType { get; set; }
        public virtual ProductionTestingDetail ProductionTestingDetail { get; set; }
    }
}
