using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production {
    public class ProductCombinationRecipeModel {
        public int GroupIndex { get; set; }
        public int RecipeId { get; set; }
        public string RecipeCode { get; set; }
        public string RecipeName { get; set; }

        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double ProductWeight { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }

        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }

        public string DetailDescription { get; set; }
        public string ProductImg { get; set; }
        public string UploadDate { get; set; }

        public double AvailableQuantity { get; set; }
        public double InvQuantity { get; set; }
        public string LotNumber { get; set; }
        public double Quantity { get; set; }
        public double QuantityKg { get; set; }
    }
    public static class ProductCombinationRecipeNote {
        public static string GetDetailDescription(List<ProductCombinationRecipeDetailModel> details) {
            var str = "";
            foreach (var detail in details) {
                str += detail.FromProductCode + "(" + detail.RequireNumber + ") - ";
            }
            return str;
        }
    }
}