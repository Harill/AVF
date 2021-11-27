using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class MaterialInventoryPeriodMap : EntityTypeConfiguration<MaterialInventoryPeriod>
    {
        public MaterialInventoryPeriodMap()
        {
            // Primary Key
            HasKey(t => t.MaterialInventoryPeriodId);

            // Properties
            Property(t => t.UnitMeasure)
                .HasMaxLength(3);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("MaterialInventoryPeriod", "Inv");
            Property(t => t.MaterialInventoryPeriodId).HasColumnName("MaterialInventoryPeriodId");
            Property(t => t.TransactionId).HasColumnName("TransactionId");
            Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            Property(t => t.MaterialId).HasColumnName("MaterialId");
            Property(t => t.PeriodDay).HasColumnName("PeriodDay");
            Property(t => t.PeriodMonth).HasColumnName("PeriodMonth");
            Property(t => t.PeriodYear).HasColumnName("PeriodYear");
            Property(t => t.PeriodDate).HasColumnName("PeriodDate");
            Property(t => t.EarlyPeriodQuantity).HasColumnName("EarlyPeriodQuantity");
            Property(t => t.EarlyPeriodQuantityKg).HasColumnName("EarlyPeriodQuantityKg");
            Property(t => t.EarlyPeriodPrice).HasColumnName("EarlyPeriodPrice");
            Property(t => t.Quantity).HasColumnName("Quantity");
            Property(t => t.QuantityKg).HasColumnName("QuantityKg");
            Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            Property(t => t.Price).HasColumnName("Price");
            Property(t => t.UnitMeasure).HasColumnName("UnitMeasure");
            Property(t => t.LastPeriodQuantity).HasColumnName("LastPeriodQuantity");
            Property(t => t.LastPeriodQuantityKg).HasColumnName("LastPeriodQuantityKg");
            Property(t => t.LastPeriodPrice).HasColumnName("LastPeriodPrice");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Material)
                .WithMany(t => t.MaterialInventoryPeriods)
                .HasForeignKey(d => d.MaterialId);
            HasRequired(t => t.Transaction)
                .WithMany(t => t.MaterialInventoryPeriods)
                .HasForeignKey(d => d.TransactionId);
            HasRequired(t => t.Warehouse)
                .WithMany(t => t.MaterialInventoryPeriods)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
