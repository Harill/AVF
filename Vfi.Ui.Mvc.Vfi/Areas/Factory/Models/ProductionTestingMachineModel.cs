using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class ProductionTestingMachineModel {

        public int TestingToolId { get; set; }
        public int Idx { get; set; }
        public int TestingDetailId { get; set; }


        public int MachineTypeId { get; set; }
        [DataType("_ProcessingTypeQCTemplate")]
        public string MachineTypeName { get; set; }

        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}