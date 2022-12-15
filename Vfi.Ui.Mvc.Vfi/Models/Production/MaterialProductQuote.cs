using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production {
    public class MaterialQuoteBaseModel {

        public int BaseId { get; set; }
        public int MaterialTypeId { get; set; }
        [DataType("_MaterialTypeEditTemplate")]
        public string MaterialTypeName { get; set; }
        public string MaterialName { get; set; }
        public string MaterialShape { get; set; }
        public string MaterialDiameterType { get; set; }
        [DataType("Number2Digit")]
        public double BasePrice { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual MaterialType MaterialType { get; set; }
    }
}