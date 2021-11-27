using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductCombinationRecipeDetail
    {
        public int DetailId { get; set; }
        public int RecipeId { get; set; }
        public int FromProductId { get; set; }
        public int RequireNumber { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductCombinationRecipe ProductCombinationRecipe { get; set; }
    }
}
