using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class SectionProcessModel {

        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public int ProductId { get; set; }
        public bool StartProcess { get; set; }
        public bool EndProcess { get; set; }
        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}