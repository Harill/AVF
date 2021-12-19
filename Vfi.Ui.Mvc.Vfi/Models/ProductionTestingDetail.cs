using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionTestingDetail
    {
        public ProductionTestingDetail()
        {
            this.RealTestings = new List<RealTesting>();
        }

        public int DetailId { get; set; }
        public int ProductionTestingId { get; set; }
        public int Idx { get; set; }
        public string TestingCode { get; set; }
        public string TestingName { get; set; }
        public Nullable<int> MachineTypeId { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual ProcessingType ProcessingType { get; set; }
        public virtual ProductionTesting ProductionTesting { get; set; }
        public virtual ICollection<RealTesting> RealTestings { get; set; }
    }
}
