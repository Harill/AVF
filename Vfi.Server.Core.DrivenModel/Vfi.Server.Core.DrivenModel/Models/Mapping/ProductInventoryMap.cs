using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class ProductInventoryMap : EntityTypeConfiguration<ProductInventory>
    {
        public ProductInventoryMap()
        {
            // Primary Key
            HasKey(t => t.ProductInventoryId);

            // Properties
            Property(t => t.UnitMeasure)
                .HasMaxLength(3);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ProductInventory", "Inv");
            Property(t => t.ProductInventoryId).HasColumnName("ProductInventoryId");
            Property(t => t.ProductId).HasColumnName("ProductId");
            Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            Property(t => t.TotalQty).HasColumnName("TotalQty");
            Property(t => t.AvailableQty).HasColumnName("AvailableQty");
            Property(t => t.UnavailableQty).HasColumnName("UnavailableQty");
            Property(t => t.UnitMeasure).HasColumnName("UnitMeasure");
            Property(t => t.Status).HasColumnName("Status");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Product)
                .WithMany(t => t.ProductInventories)
                .HasForeignKey(d => d.ProductId);
            HasRequired(t => t.Warehouse)
                .WithMany(t => t.ProductInventories)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
