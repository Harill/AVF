using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class ProductionTestingDetailModel {

        public int DetailId { get; set; }
        public int ProductionTestingId { get; set; }
        public int Idx { get; set; }
        public string TestingCode { get; set; }
        public string TestingName { get; set; }

        public Nullable<int> MachineTypeId { get; set; }
        [DataType("_ProcessingTypeQcTemplate")]
        public string MachineTypeName { get; set; }

        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }


        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}