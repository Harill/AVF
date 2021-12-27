using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class RealTestingModel {

        public int RealTestId { get; set; }
        public int ReferenceTestingDetailId { get; set; }
        public int Idx { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int ProductionMachineId { get; set; }
        public System.DateTime ProductionDate { get; set; }
        public System.DateTime TestDate { get; set; }
        public int TestEmployeeId { get; set; }
        public Nullable<int> MachineTypeId { get; set; }
        public string MachineTypeName { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        [DataType("Number4")]
        public double TestNumber { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int FromWarehouseId { get; set; }
    }
}