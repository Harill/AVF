using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SectionProcessPeriodMap : EntityTypeConfiguration<SectionProcessPeriod>
    {
        public SectionProcessPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodId);

            // Properties
            // Table & Column Mappings
            this.ToTable("SectionProcessPeriod", "Factory");
            this.Property(t => t.PeriodId).HasColumnName("PeriodId");
            this.Property(t => t.PeriodDate).HasColumnName("PeriodDate");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.TransactionDetailId).HasColumnName("TransactionDetailId");
            this.Property(t => t.ProcessId).HasColumnName("ProcessId");
            this.Property(t => t.ProcessInvId).HasColumnName("ProcessInvId");
            this.Property(t => t.EarlyQuantity).HasColumnName("EarlyQuantity");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.LastQuantity).HasColumnName("LastQuantity");

            // Relationships
            this.HasRequired(t => t.SectionProcessInventory)
                .WithMany(t => t.SectionProcessPeriods)
                .HasForeignKey(d => d.ProcessInvId);
            this.HasRequired(t => t.SectionProcessTransaction)
                .WithMany(t => t.SectionProcessPeriods)
                .HasForeignKey(d => d.TransactionId);
            this.HasRequired(t => t.SectionProcessTransactionDetail)
                .WithMany(t => t.SectionProcessPeriods)
                .HasForeignKey(d => d.TransactionDetailId);

        }
    }
}
