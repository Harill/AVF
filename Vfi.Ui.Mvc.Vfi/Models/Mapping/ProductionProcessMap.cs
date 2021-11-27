using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionProcessMap : EntityTypeConfiguration<ProductionProcess>
    {
        public ProductionProcessMap()
        {
            // Primary Key
            this.HasKey(t => t.ProcessId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionProcess", "Factory");
            this.Property(t => t.ProcessId).HasColumnName("ProcessId");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.IsAlert).HasColumnName("IsAlert");
            this.Property(t => t.IsNecessary).HasColumnName("IsNecessary");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ProcessIndex).HasColumnName("ProcessIndex");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductionProcesses)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.ProductionProcesses)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
