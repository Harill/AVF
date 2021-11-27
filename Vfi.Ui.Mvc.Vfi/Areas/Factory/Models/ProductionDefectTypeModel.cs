using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class ProductionDefectTypeModel {
        public int DefectTypeId { get; set; }
        public string DefectTypeName { get; set; }
        public string DefectTypeCode { get; set; }
        public string Description { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }
    }
}