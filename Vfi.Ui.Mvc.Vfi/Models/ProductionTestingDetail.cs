using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionTestingDetail
    {
        public ProductionTestingDetail()
        {
            this.ProductionTestingMachines = new List<ProductionTestingMachine>();
            this.RealTestings = new List<RealTesting>();
        }

        public int DetailId { get; set; }
        public int ProductionTestingId { get; set; }
        public int Idx { get; set; }
        public string TestingCode { get; set; }
        public string TestingName { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public double MinNumber { get; set; }
        public double MaxNumber { get; set; }
        public double TestRate { get; set; }
        public virtual ProductionTesting ProductionTesting { get; set; }
        public virtual ICollection<ProductionTestingMachine> ProductionTestingMachines { get; set; }
        public virtual ICollection<RealTesting> RealTestings { get; set; }
    }
}
