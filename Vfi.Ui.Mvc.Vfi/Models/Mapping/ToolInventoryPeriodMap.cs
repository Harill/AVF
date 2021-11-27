using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ToolInventoryPeriodMap : EntityTypeConfiguration<ToolInventoryPeriod>
    {
        public ToolInventoryPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ToolInventoryPeriod", "Inv");
            this.Property(t => t.PeriodId).HasColumnName("PeriodId");
            this.Property(t => t.ToolInvId).HasColumnName("ToolInvId");
            this.Property(t => t.ToolId).HasColumnName("ToolId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.EarlyQuantity).HasColumnName("EarlyQuantity");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.LastQuantity).HasColumnName("LastQuantity");
            this.Property(t => t.PeriodDate).HasColumnName("PeriodDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasRequired(t => t.Tool)
                .WithMany(t => t.ToolInventoryPeriods)
                .HasForeignKey(d => d.ToolId);
            this.HasRequired(t => t.ToolInventory)
                .WithMany(t => t.ToolInventoryPeriods)
                .HasForeignKey(d => d.ToolInvId);
            this.HasRequired(t => t.TransactionFpt)
                .WithMany(t => t.ToolInventoryPeriods)
                .HasForeignKey(d => d.TransactionId);

        }
    }
}
