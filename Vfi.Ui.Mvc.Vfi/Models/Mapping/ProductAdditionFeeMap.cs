using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductAdditionFeeMap : EntityTypeConfiguration<ProductAdditionFee>
    {
        public ProductAdditionFeeMap()
        {
            // Primary Key
            this.HasKey(t => t.FeeId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductAdditionFee", "Production");
            this.Property(t => t.FeeId).HasColumnName("FeeId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductAdditionFees)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
