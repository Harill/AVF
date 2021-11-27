using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production {
    public class ProductCombinationRecipeModel {
        public int RecipeId { get; set; }
        public string RecipeCode { get; set; }
        public string RecipeName { get; set; }

        public int ProductId { get; set; }
        public string ProductCode { get; set; }

        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }

        public string DetailDescription { get; set; }
        public string ProductImg { get; set; }
        public string UploadDate { get; set; }
        public string GetDetailDescription(List<ProductCombinationRecipeDetailModel> details) {
            var str ="";
            foreach (var detail in details) {
                str += detail.FromProductCode + "(" + detail.RequireNumber + ") - ";
            }
            return str;
        }
    }
}