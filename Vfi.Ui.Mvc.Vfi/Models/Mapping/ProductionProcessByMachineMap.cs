using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionProcessByMachineMap : EntityTypeConfiguration<ProductionProcessByMachine>
    {
        public ProductionProcessByMachineMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionProcessByMachine", "Factory");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.ProcessIndex).HasColumnName("ProcessIndex");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.UnitWeight).HasColumnName("UnitWeight");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");

            // Relationships
            this.HasRequired(t => t.Machine)
                .WithMany(t => t.ProductionProcessByMachines)
                .HasForeignKey(d => d.MachineId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductionProcessByMachines)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.ProductionProcessByMachines)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
