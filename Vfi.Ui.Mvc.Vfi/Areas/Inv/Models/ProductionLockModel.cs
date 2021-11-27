using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class ProductionLockModel {
        public int LockId { get; set; }
        [UIHint("_DateTemplate")]
        public DateTime LockDate { get; set; }
        public bool Production1Lock { get; set; }
        public bool Production2Lock { get; set; }
        public bool CNCLock { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime ModifiedDate { get; set; }

        public string Shift1Name { get; set; }
        public string Shift2Name { get; set; }
    }
}