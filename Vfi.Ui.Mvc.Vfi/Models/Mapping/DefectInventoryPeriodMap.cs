using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class DefectInventoryPeriodMap : EntityTypeConfiguration<DefectInventoryPeriod>
    {
        public DefectInventoryPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodId);

            // Properties
            // Table & Column Mappings
            this.ToTable("DefectInventoryPeriod", "Factory");
            this.Property(t => t.PeriodId).HasColumnName("PeriodId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.InvId).HasColumnName("InvId");
            this.Property(t => t.PeriodDate).HasColumnName("PeriodDate");
            this.Property(t => t.EarlyQuantity).HasColumnName("EarlyQuantity");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.LastQuantity).HasColumnName("LastQuantity");
            this.Property(t => t.Weight).HasColumnName("Weight");

            // Relationships
            this.HasRequired(t => t.DefectInventory)
                .WithMany(t => t.DefectInventoryPeriods)
                .HasForeignKey(d => d.InvId);
            this.HasRequired(t => t.DefectTransaction)
                .WithMany(t => t.DefectInventoryPeriods)
                .HasForeignKey(d => d.TransactionId);

        }
    }
}
