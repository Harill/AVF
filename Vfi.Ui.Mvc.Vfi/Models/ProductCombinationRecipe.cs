using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductCombinationRecipe
    {
        public ProductCombinationRecipe()
        {
            this.ProductCombinationRecipeDetails = new List<ProductCombinationRecipeDetail>();
        }

        public int RecipeId { get; set; }
        public int ProductId { get; set; }
        public string RecipeCode { get; set; }
        public string RecipeName { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<ProductCombinationRecipeDetail> ProductCombinationRecipeDetails { get; set; }
    }
}
