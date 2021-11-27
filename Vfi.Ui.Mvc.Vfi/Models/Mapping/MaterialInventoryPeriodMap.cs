using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MaterialInventoryPeriodMap : EntityTypeConfiguration<MaterialInventoryPeriod>
    {
        public MaterialInventoryPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.MaterialInventoryPeriodId);

            // Properties
            this.Property(t => t.UnitMeasure)
                .HasMaxLength(3);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaterialInventoryPeriod", "Inv");
            this.Property(t => t.MaterialInventoryPeriodId).HasColumnName("MaterialInventoryPeriodId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.MaterialId).HasColumnName("MaterialId");
            this.Property(t => t.PeriodDay).HasColumnName("PeriodDay");
            this.Property(t => t.PeriodMonth).HasColumnName("PeriodMonth");
            this.Property(t => t.PeriodYear).HasColumnName("PeriodYear");
            this.Property(t => t.PeriodDate).HasColumnName("PeriodDate");
            this.Property(t => t.EarlyPeriodQuantity).HasColumnName("EarlyPeriodQuantity");
            this.Property(t => t.EarlyPeriodQuantityKg).HasColumnName("EarlyPeriodQuantityKg");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.QuantityKg).HasColumnName("QuantityKg");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.UnitMeasure).HasColumnName("UnitMeasure");
            this.Property(t => t.LastPeriodQuantity).HasColumnName("LastPeriodQuantity");
            this.Property(t => t.LastPeriodQuantityKg).HasColumnName("LastPeriodQuantityKg");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.MaterialInventoryId).HasColumnName("MaterialInventoryId");
            this.Property(t => t.IsDestroyed).HasColumnName("IsDestroyed");

            // Relationships
            this.HasRequired(t => t.MaterialInventory)
                .WithMany(t => t.MaterialInventoryPeriods)
                .HasForeignKey(d => d.MaterialInventoryId);
            this.HasRequired(t => t.Material)
                .WithMany(t => t.MaterialInventoryPeriods)
                .HasForeignKey(d => d.MaterialId);
            this.HasRequired(t => t.Transaction)
                .WithMany(t => t.MaterialInventoryPeriods)
                .HasForeignKey(d => d.TransactionId);

        }
    }
}
