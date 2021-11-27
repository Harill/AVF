using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SmartProductionMap : EntityTypeConfiguration<SmartProduction>
    {
        public SmartProductionMap()
        {
            // Primary Key
            this.HasKey(t => t.SmartId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.UnitMeasure)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SmartProduction", "Factory");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.MaterialInvId).HasColumnName("MaterialInvId");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.SmartId).HasColumnName("SmartId");
            this.Property(t => t.ProductionRate).HasColumnName("ProductionRate");
            this.Property(t => t.FuelInvId).HasColumnName("FuelInvId");
            this.Property(t => t.ToolInvId).HasColumnName("ToolInvId");
            this.Property(t => t.ProductInvId).HasColumnName("ProductInvId");
            this.Property(t => t.UnitMeasure).HasColumnName("UnitMeasure");
            this.Property(t => t.BoxWeight).HasColumnName("BoxWeight");

            // Relationships
            this.HasOptional(t => t.Machine)
                .WithMany(t => t.SmartProductions)
                .HasForeignKey(d => d.MachineId);
            this.HasOptional(t => t.MaterialInventory)
                .WithMany(t => t.SmartProductions)
                .HasForeignKey(d => d.MaterialInvId);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.SmartProductions)
                .HasForeignKey(d => d.ProductId);
            this.HasOptional(t => t.ProductInventory)
                .WithMany(t => t.SmartProductions)
                .HasForeignKey(d => d.ProductInvId);
            this.HasOptional(t => t.Warehouse)
                .WithMany(t => t.SmartProductions)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
