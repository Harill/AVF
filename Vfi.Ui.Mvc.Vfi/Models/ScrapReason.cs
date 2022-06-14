using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ScrapReason
    {
        public ScrapReason()
        {
            this.WorkOrder1 = new List<WorkOrder1>();
        }

        public int ScrapReasonId { get; set; }
        public string ScrapReasonName { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<WorkOrder1> WorkOrder1 { get; set; }
    }
}
