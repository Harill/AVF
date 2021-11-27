using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductCombinationRecipeMap : EntityTypeConfiguration<ProductCombinationRecipe>
    {
        public ProductCombinationRecipeMap()
        {
            // Primary Key
            this.HasKey(t => t.RecipeId);

            // Properties
            this.Property(t => t.RecipeCode)
                .HasMaxLength(50);

            this.Property(t => t.RecipeName)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductCombinationRecipe", "Production");
            this.Property(t => t.RecipeId).HasColumnName("RecipeId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.RecipeCode).HasColumnName("RecipeCode");
            this.Property(t => t.RecipeName).HasColumnName("RecipeName");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductCombinationRecipes)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
