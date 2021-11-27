using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class ProductInventoryPeriodMap : EntityTypeConfiguration<ProductInventoryPeriod>
    {
        public ProductInventoryPeriodMap()
        {
            // Primary Key
            HasKey(t => t.ProductInventoryPeriodId);

            // Properties
            Property(t => t.UnitMeasure)
                .HasMaxLength(3);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ProductInventoryPeriod", "Inv");
            Property(t => t.ProductInventoryPeriodId).HasColumnName("ProductInventoryPeriodId");
            Property(t => t.TransactionId).HasColumnName("TransactionId");
            Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            Property(t => t.ProductId).HasColumnName("ProductId");
            Property(t => t.PeriodDay).HasColumnName("PeriodDay");
            Property(t => t.PeriodMonth).HasColumnName("PeriodMonth");
            Property(t => t.PeriodYear).HasColumnName("PeriodYear");
            Property(t => t.PeriodDate).HasColumnName("PeriodDate");
            Property(t => t.EarlyPeriodQuantity).HasColumnName("EarlyPeriodQuantity");
            Property(t => t.EarlyPeriodPrice).HasColumnName("EarlyPeriodPrice");
            Property(t => t.Quantity).HasColumnName("Quantity");
            Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            Property(t => t.Price).HasColumnName("Price");
            Property(t => t.UnitMeasure).HasColumnName("UnitMeasure");
            Property(t => t.LastPeriodQuantity).HasColumnName("LastPeriodQuantity");
            Property(t => t.LastPeriodPrice).HasColumnName("LastPeriodPrice");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Product)
                .WithMany(t => t.ProductInventoryPeriods)
                .HasForeignKey(d => d.ProductId);
            HasRequired(t => t.Transaction)
                .WithMany(t => t.ProductInventoryPeriods)
                .HasForeignKey(d => d.TransactionId);
            HasRequired(t => t.Warehouse)
                .WithMany(t => t.ProductInventoryPeriods)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
