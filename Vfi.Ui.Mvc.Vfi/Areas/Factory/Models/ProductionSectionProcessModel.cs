using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class ProductionSectionProcessModel {

        public int PSPId { get; set; }
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public int NextProcessId { get; set; }
        [DataType("_SectionNextProcessTemplate")]
        public string NextProcessName { get; set; }
        [DataType("Number2Digit")]
        public double Productivity { get; set; }
        [DataType("Number3Digit")]
        public double UnitWeight { get; set; }
        [DataType("Number0Digit")]
        public double UnitPrice { get; set; }
        public string UnitMeasure { get; set; }
        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}