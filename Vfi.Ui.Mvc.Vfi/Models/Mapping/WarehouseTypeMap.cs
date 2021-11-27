using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class WarehouseTypeMap : EntityTypeConfiguration<WarehouseType>
    {
        public WarehouseTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.WarehouseTypeId);

            // Properties
            this.Property(t => t.WarehouseTypeName)
                .HasMaxLength(255);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseType", "Inv");
            this.Property(t => t.WarehouseTypeId).HasColumnName("WarehouseTypeId");
            this.Property(t => t.WarehouseTypeName).HasColumnName("WarehouseTypeName");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
