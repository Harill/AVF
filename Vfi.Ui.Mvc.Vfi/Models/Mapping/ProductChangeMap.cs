using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductChangeMap : EntityTypeConfiguration<ProductChange>
    {
        public ProductChangeMap()
        {
            // Primary Key
            this.HasKey(t => t.ChangeId);

            // Properties
            this.Property(t => t.OldProductCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NewProductCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductChange", "Production");
            this.Property(t => t.ChangeId).HasColumnName("ChangeId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.OldProductCode).HasColumnName("OldProductCode");
            this.Property(t => t.NewProductCode).HasColumnName("NewProductCode");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.OldPrice).HasColumnName("OldPrice");
            this.Property(t => t.NewPrice).HasColumnName("NewPrice");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductChanges)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
