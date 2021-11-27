using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class WarehousePermissionMap : EntityTypeConfiguration<WarehousePermission>
    {
        public WarehousePermissionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("WarehousePermission", "System");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Import).HasColumnName("Import");
            this.Property(t => t.Rotate).HasColumnName("Rotate");
            this.Property(t => t.OrderProgress).HasColumnName("OrderProgress");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.Warehouse)
                .WithMany(t => t.WarehousePermissions)
                .HasForeignKey(d => d.WarehouseId);
            this.HasOptional(t => t.User)
                .WithMany(t => t.WarehousePermissions)
                .HasForeignKey(d => d.UserId);

        }
    }
}
