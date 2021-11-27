using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class TechnicalHandoverModel {

        public int FormId { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int StateId { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }

        public DateTime ReportDate { get; set; }

        public int CountErrorState { get; set; }
        public DateTime CauseDate { get; set; }

        public int EstimateTime { get; set; }
        public bool BetweenTime {
            get {
                return EstimateTime > 30 && EstimateTime < 120 ? true : false;
            }
        }
    }
}