using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class ShipMethodMap : EntityTypeConfiguration<ShipMethod>
    {
        public ShipMethodMap()
        {
            // Primary Key
            HasKey(t => t.ShipMethodId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ShipMethod", "Purchasing");
            Property(t => t.ShipMethodId).HasColumnName("ShipMethodId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.ShipBase).HasColumnName("ShipBase");
            Property(t => t.ShipRate).HasColumnName("ShipRate");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
