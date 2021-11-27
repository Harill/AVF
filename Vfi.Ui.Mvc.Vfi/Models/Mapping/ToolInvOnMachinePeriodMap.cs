using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ToolInvOnMachinePeriodMap : EntityTypeConfiguration<ToolInvOnMachinePeriod>
    {
        public ToolInvOnMachinePeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodId);

            // Properties
            this.Property(t => t.Note)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ToolInvOnMachinePeriod", "Inv");
            this.Property(t => t.PeriodId).HasColumnName("PeriodId");
            this.Property(t => t.ToolInvMachineId).HasColumnName("ToolInvMachineId");
            this.Property(t => t.PeriodDate).HasColumnName("PeriodDate");
            this.Property(t => t.EarlyQuantity).HasColumnName("EarlyQuantity");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.LastQuantity).HasColumnName("LastQuantity");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.UseId).HasColumnName("UseId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");

            // Relationships
            this.HasRequired(t => t.ToolInvOnMachine)
                .WithMany(t => t.ToolInvOnMachinePeriods)
                .HasForeignKey(d => d.ToolInvMachineId);
            this.HasOptional(t => t.ToolUse)
                .WithMany(t => t.ToolInvOnMachinePeriods)
                .HasForeignKey(d => d.UseId);
            this.HasOptional(t => t.TransactionFpt)
                .WithMany(t => t.ToolInvOnMachinePeriods)
                .HasForeignKey(d => d.TransactionId);

        }
    }
}
