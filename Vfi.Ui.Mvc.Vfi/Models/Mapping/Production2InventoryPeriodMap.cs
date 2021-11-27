using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class Production2InventoryPeriodMap : EntityTypeConfiguration<Production2InventoryPeriod>
    {
        public Production2InventoryPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Production2InventoryPeriod", "Factory");
            this.Property(t => t.PeriodId).HasColumnName("PeriodId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.InvId).HasColumnName("InvId");
            this.Property(t => t.PeriodDate).HasColumnName("PeriodDate");
            this.Property(t => t.EarlyQuantity).HasColumnName("EarlyQuantity");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.LastQuantity).HasColumnName("LastQuantity");
            this.Property(t => t.Weight).HasColumnName("Weight");

            // Relationships
            this.HasRequired(t => t.Production2Inventory)
                .WithMany(t => t.Production2InventoryPeriod)
                .HasForeignKey(d => d.InvId);

        }
    }
}
