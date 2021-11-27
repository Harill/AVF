using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class FuelMap : EntityTypeConfiguration<Fuel>
    {
        public FuelMap()
        {
            // Primary Key
            this.HasKey(t => t.FuelId);

            // Properties
            this.Property(t => t.FuelName)
                .HasMaxLength(50);

            this.Property(t => t.FuelCode)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.FuelFullCode)
                .HasMaxLength(50);

            this.Property(t => t.FuelDesignNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Fuel", "Factory");
            this.Property(t => t.FuelId).HasColumnName("FuelId");
            this.Property(t => t.FuelName).HasColumnName("FuelName");
            this.Property(t => t.FuelCode).HasColumnName("FuelCode");
            this.Property(t => t.FuelDesctiption).HasColumnName("FuelDesctiption");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.FuelFullCode).HasColumnName("FuelFullCode");
            this.Property(t => t.FuelDesignNo).HasColumnName("FuelDesignNo");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.UnitWeight).HasColumnName("UnitWeight");
        }
    }
}
