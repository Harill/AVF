using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class WarehouseRotateMap : EntityTypeConfiguration<WarehouseRotate>
    {
        public WarehouseRotateMap()
        {
            // Primary Key
            this.HasKey(t => t.RotateId);

            // Properties
            // Table & Column Mappings
            this.ToTable("WarehouseRotate", "System");
            this.Property(t => t.RotateId).HasColumnName("RotateId");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.ToWarehouseId).HasColumnName("ToWarehouseId");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.WarehouseRotates)
                .HasForeignKey(d => d.WarehouseId);
            this.HasRequired(t => t.Warehouse1)
                .WithMany(t => t.WarehouseRotates1)
                .HasForeignKey(d => d.ToWarehouseId);

        }
    }
}
