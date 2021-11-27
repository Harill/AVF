using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SelectMaterialInvAndPeriodMap : EntityTypeConfiguration<SelectMaterialInvAndPeriod>
    {
        public SelectMaterialInvAndPeriodMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MaterialInventoryId, t.MaterialId, t.VendorId, t.TotalQuantity });

            // Properties
            this.Property(t => t.MaterialInventoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MaterialId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MaterialCode)
                .HasMaxLength(50);

            this.Property(t => t.LotNumber)
                .HasMaxLength(50);

            this.Property(t => t.VendorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("SelectMaterialInvAndPeriod");
            this.Property(t => t.MaterialInventoryId).HasColumnName("MaterialInventoryId");
            this.Property(t => t.MaterialId).HasColumnName("MaterialId");
            this.Property(t => t.MaterialCode).HasColumnName("MaterialCode");
            this.Property(t => t.LotNumber).HasColumnName("LotNumber");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.VendorName).HasColumnName("VendorName");
            this.Property(t => t.TotalQuantity).HasColumnName("TotalQuantity");
            this.Property(t => t.PeriodQuantity).HasColumnName("PeriodQuantity");
        }
    }
}
