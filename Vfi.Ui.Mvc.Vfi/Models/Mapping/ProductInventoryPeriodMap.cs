using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductInventoryPeriodMap : EntityTypeConfiguration<ProductInventoryPeriod>
    {
        public ProductInventoryPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductInventoryPeriodId);

            // Properties
            this.Property(t => t.UnitMeasure)
                .HasMaxLength(3);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductInventoryPeriod", "Inv");
            this.Property(t => t.ProductInventoryPeriodId).HasColumnName("ProductInventoryPeriodId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.PeriodDay).HasColumnName("PeriodDay");
            this.Property(t => t.PeriodMonth).HasColumnName("PeriodMonth");
            this.Property(t => t.PeriodYear).HasColumnName("PeriodYear");
            this.Property(t => t.PeriodDate).HasColumnName("PeriodDate");
            this.Property(t => t.EarlyPeriodQuantity).HasColumnName("EarlyPeriodQuantity");
            this.Property(t => t.EarlyPeriodPrice).HasColumnName("EarlyPeriodPrice");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.UnitMeasure).HasColumnName("UnitMeasure");
            this.Property(t => t.LastPeriodQuantity).HasColumnName("LastPeriodQuantity");
            this.Property(t => t.LastPeriodPrice).HasColumnName("LastPeriodPrice");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ProductInvId).HasColumnName("ProductInvId");
            this.Property(t => t.LotNumber).HasColumnName("LotNumber");

            // Relationships
            this.HasRequired(t => t.ProductInventory)
                .WithMany(t => t.ProductInventoryPeriods)
                .HasForeignKey(d => d.ProductInvId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductInventoryPeriods)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.Transaction)
                .WithMany(t => t.ProductInventoryPeriods)
                .HasForeignKey(d => d.TransactionId);
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.ProductInventoryPeriods)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
