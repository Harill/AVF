using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class InventoryShelfMap : EntityTypeConfiguration<InventoryShelf>
    {
        public InventoryShelfMap()
        {
            // Primary Key
            this.HasKey(t => t.ShelfId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);
            this.Property(t => t.ShelfName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InventoryShelf", "Inv");
            this.Property(t => t.ShelfId).HasColumnName("ShelfId");
            this.Property(t => t.ClassifiedId).HasColumnName("ClassifiedId");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.MaxColumn).HasColumnName("MaxColumn");
            this.Property(t => t.MaxRow).HasColumnName("MaxRow");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ShelfName).HasColumnName("ShelfName");

            // Relationships
            this.HasRequired(t => t.MaterialClassified)
                .WithMany(t => t.InventoryShelves)
                .HasForeignKey(d => d.ClassifiedId);
            this.HasOptional(t => t.Warehouse)
                .WithMany(t => t.InventoryShelves)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
