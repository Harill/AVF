using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SelectFuelInvAndPeriodMap : EntityTypeConfiguration<SelectFuelInvAndPeriod>
    {
        public SelectFuelInvAndPeriodMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FuelInvId, t.FuelId, t.VendorId, t.TotalQuantity });

            // Properties
            this.Property(t => t.FuelInvId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FuelId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FuelFullCode)
                .HasMaxLength(50);

            this.Property(t => t.VendorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorName)
                .HasMaxLength(255);

            this.Property(t => t.LotNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SelectFuelInvAndPeriod");
            this.Property(t => t.FuelInvId).HasColumnName("FuelInvId");
            this.Property(t => t.FuelId).HasColumnName("FuelId");
            this.Property(t => t.FuelFullCode).HasColumnName("FuelFullCode");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.VendorName).HasColumnName("VendorName");
            this.Property(t => t.TotalQuantity).HasColumnName("TotalQuantity");
            this.Property(t => t.LotNumber).HasColumnName("LotNumber");
            this.Property(t => t.PeriodQuantity).HasColumnName("PeriodQuantity");
        }
    }
}
