using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class FuelInventoryPeriodMap : EntityTypeConfiguration<FuelInventoryPeriod>
    {
        public FuelInventoryPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FuelInventoryPeriod", "Inv");
            this.Property(t => t.PeriodId).HasColumnName("PeriodId");
            this.Property(t => t.FuelInvId).HasColumnName("FuelInvId");
            this.Property(t => t.FuelId).HasColumnName("FuelId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.EarlyQuantity).HasColumnName("EarlyQuantity");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.LastQuantity).HasColumnName("LastQuantity");
            this.Property(t => t.PeriodDate).HasColumnName("PeriodDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasRequired(t => t.Fuel)
                .WithMany(t => t.FuelInventoryPeriods)
                .HasForeignKey(d => d.FuelId);
            this.HasRequired(t => t.FuelInventory)
                .WithMany(t => t.FuelInventoryPeriods)
                .HasForeignKey(d => d.FuelInvId);
            this.HasRequired(t => t.TransactionFpt)
                .WithMany(t => t.FuelInventoryPeriods)
                .HasForeignKey(d => d.TransactionId);

        }
    }
}
