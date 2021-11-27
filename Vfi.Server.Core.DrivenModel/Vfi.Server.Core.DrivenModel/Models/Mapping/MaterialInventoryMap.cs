using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class MaterialInventoryMap : EntityTypeConfiguration<MaterialInventory>
    {
        public MaterialInventoryMap()
        {
            // Primary Key
            HasKey(t => t.MaterialInventoryId);

            // Properties
            Property(t => t.UnitMeasure)
                .HasMaxLength(3);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("MaterialInventory", "Inv");
            Property(t => t.MaterialInventoryId).HasColumnName("MaterialInventoryId");
            Property(t => t.MaterialId).HasColumnName("MaterialId");
            Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            Property(t => t.TotalQty).HasColumnName("TotalQty");
            Property(t => t.TotalQtyKg).HasColumnName("TotalQtyKg");
            Property(t => t.AvailableQty).HasColumnName("AvailableQty");
            Property(t => t.UnavailableQty).HasColumnName("UnavailableQty");
            Property(t => t.UnitMeasure).HasColumnName("UnitMeasure");
            Property(t => t.Status).HasColumnName("Status");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Material)
                .WithMany(t => t.MaterialInventories)
                .HasForeignKey(d => d.MaterialId);
            HasRequired(t => t.Warehouse)
                .WithMany(t => t.MaterialInventories)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
