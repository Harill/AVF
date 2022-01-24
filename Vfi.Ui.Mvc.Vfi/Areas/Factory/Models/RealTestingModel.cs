using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class RealTestingModel {
        public RealTestingModel() {
            TypeIds = new List<int>();
        }
        public int RealTestId { get; set; }
        public int ReferenceTestingDetailId { get; set; }
        public int Idx { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int FromWarehouseId { get; set; }
        public int ProductionMachineId { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime TestDate { get; set; }

        public int TestEmployeeId { get; set; }
        public string TestEmployeeName { get; set; }

        public List<int> TypeIds { get; set; }
        public string TypeIdsStr { get; set; }
        public string MachineTypeName { get; set; }
        public Nullable<int> MachineId { get; set; }
        [DataType("_MachineQCByTypeTemplate")]
        public string MachineName { get; set; }

        public string TestCode { get; set; }
        public string TestName { get; set; }
        public double MinNumber { get; set; }
        public double MaxNumber { get; set; }
        public double TestRate { get; set; }
        [DataType("Number4")]
        public double TestNumber { get; set; }
        
        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}