using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production {
    public class ProductMaterialDesignModel {
        public int ProductId { get; set; }
        public int MaterialId { get; set; }
        [UIHint("_MaterialEditTemplate")]
        public string MaterialCode { get; set; }

        public string MaterialName { get; set; }
        public double OutDiameter { get; set; }
        public double InDiameter { get; set; }
        public string Shape { get; set; }
        public string DiameterType { get; set; }

        public double ProductMaterialWeight { get; set; }
        public double MaterialBasePrice { get; set; }
        public double MaterialPrice { get; set; }
    }
}