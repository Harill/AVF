using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ToolPeriodMap : EntityTypeConfiguration<ToolPeriod>
    {
        public ToolPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.ToolPeriodId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ToolPeriod", "Factory");
            this.Property(t => t.ToolPeriodId).HasColumnName("ToolPeriodId");
            this.Property(t => t.ToolId).HasColumnName("ToolId");
            this.Property(t => t.PeriodDay).HasColumnName("PeriodDay");
            this.Property(t => t.PeriodMonth).HasColumnName("PeriodMonth");
            this.Property(t => t.PeriodYear).HasColumnName("PeriodYear");
            this.Property(t => t.PeriodDate).HasColumnName("PeriodDate");
            this.Property(t => t.EarlyPeriodQuantity).HasColumnName("EarlyPeriodQuantity");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.LastPeriodQuantity).HasColumnName("LastPeriodQuantity");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Tool)
                .WithMany(t => t.ToolPeriods)
                .HasForeignKey(d => d.ToolId);

        }
    }
}
