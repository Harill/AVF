using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class ProductionDefectModel {

        public int DefectId { get; set; }
        public string DefectCode { get; set; }
        [DataType("_ProductionDefectNameRecommend")]
        public string DefectName { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        [DataType("_ProductEditTemplate")]
        public string ProductCode { get; set; }

        public int DefectTypeId { get; set; }
        [DataType("_ProductionDefectTypeTemplate")]
        public string DefectTypeCode { get; set; }
        public string DefectTypeName { get; set; }

        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }

        public bool IsUsing { get; set; }

        public int DefaultRemedyId { get; set; }
        [DataType("_ProductionDefectRemedyTemplate")]
        public string RemedyName { get; set; }
        public int WarehouseProcessId { get; set; }
        public string WarehouseProcessName { get; set; }
    }
}