using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production {
    public class ProductCombinationRecipeDetailModel {
        public int DetailId { get; set; }
        public int RecipeId { get; set; }
        public int FromProductId { get; set; }
        [DataType("_ProductEditTemplate")]
        public string FromProductCode { get; set; }
        [DataType("Int")]
        public int RequireNumber { get; set; }
        public double InvQuantity { get; set; }
        public double CombineQuantity { get; set; }
    }
}