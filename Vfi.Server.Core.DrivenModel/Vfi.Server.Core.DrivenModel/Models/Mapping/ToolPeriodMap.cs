using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class ToolPeriodMap : EntityTypeConfiguration<ToolPeriod>
    {
        public ToolPeriodMap()
        {
            // Primary Key
            HasKey(t => t.ToolPeriodId);

            // Properties
            Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ToolPeriod", "Factory");
            Property(t => t.ToolPeriodId).HasColumnName("ToolPeriodId");
            Property(t => t.ToolId).HasColumnName("ToolId");
            Property(t => t.PeriodDay).HasColumnName("PeriodDay");
            Property(t => t.PeriodMonth).HasColumnName("PeriodMonth");
            Property(t => t.PeriodYear).HasColumnName("PeriodYear");
            Property(t => t.PeriodDate).HasColumnName("PeriodDate");
            Property(t => t.EarlyPeriodQuantity).HasColumnName("EarlyPeriodQuantity");
            Property(t => t.Quantity).HasColumnName("Quantity");
            Property(t => t.LastPeriodQuantity).HasColumnName("LastPeriodQuantity");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Tool)
                .WithMany(t => t.ToolPeriods)
                .HasForeignKey(d => d.ToolId);

        }
    }
}
