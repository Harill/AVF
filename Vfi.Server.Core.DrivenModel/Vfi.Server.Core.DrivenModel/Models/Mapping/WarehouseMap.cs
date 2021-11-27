using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class WarehouseMap : EntityTypeConfiguration<Warehouse>
    {
        public WarehouseMap()
        {
            // Primary Key
            HasKey(t => t.WarehouseId);

            // Properties
            Property(t => t.WarehouseName)
                .HasMaxLength(50);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Warehouse", "Inv");
            Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            Property(t => t.WarehouseTypeId).HasColumnName("WarehouseTypeId");
            Property(t => t.WarehouseName).HasColumnName("WarehouseName");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.Idx).HasColumnName("Idx");
            Property(t => t.DisplayInReport).HasColumnName("DisplayInReport");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasOptional(t => t.WarehouseType)
                .WithMany(t => t.Warehouses)
                .HasForeignKey(d => d.WarehouseTypeId);

        }
    }
}
