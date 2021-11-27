using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class MachineStateStatisticModel : MachineRepairFormModel {
        public int DetailFormId { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public int StateId { get; set; }
        public string StateCode { get; set; }
        public string StatusName { get; set; }

        public int EstimateTime { get; set; }
        public double PlanTiming { get; set; }

        public string FixTimeHhMm { get; set; }

        public int EmployeeId { get; set; }
        public string EmployeeRepairName { get; set; }
        public string EmployeeQcName { get; set; }
        public string Note { get; set; }
    }

}