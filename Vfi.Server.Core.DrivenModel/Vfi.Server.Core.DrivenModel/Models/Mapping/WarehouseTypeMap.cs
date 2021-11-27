using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class WarehouseTypeMap : EntityTypeConfiguration<WarehouseType>
    {
        public WarehouseTypeMap()
        {
            // Primary Key
            HasKey(t => t.WarehouseTypeId);

            // Properties
            Property(t => t.WarehouseTypeName)
                .HasMaxLength(255);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("WarehouseType", "Inv");
            Property(t => t.WarehouseTypeId).HasColumnName("WarehouseTypeId");
            Property(t => t.WarehouseTypeName).HasColumnName("WarehouseTypeName");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
