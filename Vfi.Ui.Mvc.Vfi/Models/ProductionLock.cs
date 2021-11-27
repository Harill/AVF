using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionLock
    {
        public int LockId { get; set; }
        public System.DateTime LockDate { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool Production1Lock { get; set; }
        public bool Production2Lock { get; set; }
        public bool CNCLock { get; set; }
        public string Shift1Name { get; set; }
        public string Shift2Name { get; set; }
    }
}
