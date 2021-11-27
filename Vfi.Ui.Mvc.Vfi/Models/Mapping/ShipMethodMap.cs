using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ShipMethodMap : EntityTypeConfiguration<ShipMethod>
    {
        public ShipMethodMap()
        {
            // Primary Key
            this.HasKey(t => t.ShipMethodId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ShipMethod", "Purchasing");
            this.Property(t => t.ShipMethodId).HasColumnName("ShipMethodId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ShipBase).HasColumnName("ShipBase");
            this.Property(t => t.ShipRate).HasColumnName("ShipRate");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
