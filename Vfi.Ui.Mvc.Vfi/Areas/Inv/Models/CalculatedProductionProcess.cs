using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class CalculatedProductProcess {
        public CalculatedProductProcess() {
            WarehouseIds = new List<int>();
            AfterWarehouseProcessIds = new List<int>();
        }
        public int WarehouseProcessId { get; set; }
        public string WarehouseProcessName { get; set; }
        public List<int> WarehouseIds { get; set; }
        public List<int> AfterWarehouseProcessIds { get; set; }
        public int ProcessDay { get; set; }
        public int ProductivityInDay { get; set; }
    }
}