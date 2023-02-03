using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class MachineStateStatisticModel : MachineRepairFormModel {
        public int DetailFormId { get; set; }

        public double PlanTiming { get; set; }

        public string FixTimeHhMm { get; set; }

        public string EmployeeRepairName { get; set; }
        public string EmployeeQcName { get; set; }
        public int MaxRunTime { get; set; }
        public int RunTime { get; set; }
        public string RunTimeStr { get; set; }
        public string RunTimePercentedStr { get; set; }
        public string NotRunTimePercentedStr { get; set; }

    }

}