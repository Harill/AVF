using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionTestingMap : EntityTypeConfiguration<ProductionTesting>
    {
        public ProductionTestingMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductionTestingId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionTesting", "Factory");
            this.Property(t => t.ProductionTestingId).HasColumnName("ProductionTestingId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductionTestings)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.ProductionTestings)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
