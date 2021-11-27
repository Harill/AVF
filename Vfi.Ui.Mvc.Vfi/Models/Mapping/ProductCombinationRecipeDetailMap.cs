using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductCombinationRecipeDetailMap : EntityTypeConfiguration<ProductCombinationRecipeDetail>
    {
        public ProductCombinationRecipeDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProductCombinationRecipeDetail", "Production");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.RecipeId).HasColumnName("RecipeId");
            this.Property(t => t.FromProductId).HasColumnName("FromProductId");
            this.Property(t => t.RequireNumber).HasColumnName("RequireNumber");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductCombinationRecipeDetails)
                .HasForeignKey(d => d.FromProductId);
            this.HasRequired(t => t.ProductCombinationRecipe)
                .WithMany(t => t.ProductCombinationRecipeDetails)
                .HasForeignKey(d => d.RecipeId);

        }
    }
}
