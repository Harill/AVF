using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class ProductionHeatTreatmentModel {

        public int Id { get; set; }
        public string Name { get; set; }
        [DataType("Int")]
        public int Section { get; set; }
        [DataType("Number0")]
        public double Rate { get; set; }
        [DataType("Number0")]
        public double Timing { get; set; }
        [DataType("Number0")]
        public double Temperature { get; set; }
        [DataType("Number0")]
        public double Stiffness { get; set; }

        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }

        public string Note { get; set; }

        public bool Active { get; set; }

        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }

        public int MachineId { get; set; }
        [DataType("_MachineHeatTreamentTemplate")]
        public string MachineName { get; set; }
    }
}