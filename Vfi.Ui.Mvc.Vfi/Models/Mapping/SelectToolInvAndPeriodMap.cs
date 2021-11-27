using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SelectToolInvAndPeriodMap : EntityTypeConfiguration<SelectToolInvAndPeriod>
    {
        public SelectToolInvAndPeriodMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ToolInvId, t.ToolId, t.VendorId, t.TotalQuantity });

            // Properties
            this.Property(t => t.ToolInvId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ToolId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ToolFullCode)
                .HasMaxLength(255);

            this.Property(t => t.VendorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorName)
                .HasMaxLength(255);

            this.Property(t => t.LotNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SelectToolInvAndPeriod");
            this.Property(t => t.ToolInvId).HasColumnName("ToolInvId");
            this.Property(t => t.ToolId).HasColumnName("ToolId");
            this.Property(t => t.ToolFullCode).HasColumnName("ToolFullCode");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.VendorName).HasColumnName("VendorName");
            this.Property(t => t.TotalQuantity).HasColumnName("TotalQuantity");
            this.Property(t => t.LotNumber).HasColumnName("LotNumber");
            this.Property(t => t.PeriodQuantity).HasColumnName("PeriodQuantity");
        }
    }
}
