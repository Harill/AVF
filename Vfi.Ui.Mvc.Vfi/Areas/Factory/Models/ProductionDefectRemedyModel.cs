using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class ProductionDefectRemedyModel {

        public int RemedyId { get; set; }
        public string RemedyCode { get; set; }
        public string RemedyName { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public bool Active { get; set; }

        public int ProcessWarehouseId { get; set; }
        [DataType("_WarehouseNextEditTemplate")]
        public string ProcessWarehouseName { get; set; }
    }
}