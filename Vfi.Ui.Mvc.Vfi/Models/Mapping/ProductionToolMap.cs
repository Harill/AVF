using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionToolMap : EntityTypeConfiguration<ProductionTool>
    {
        public ProductionToolMap()
        {
            // Primary Key
            this.HasKey(t => t.RealToolId);

            // Properties
            this.Property(t => t.Note)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.ToolLocation)
                .HasMaxLength(5);

            this.Property(t => t.Description)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionTool", "Factory");
            this.Property(t => t.RealToolId).HasColumnName("RealToolId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ToolId).HasColumnName("ToolId");
            this.Property(t => t.UseNumber).HasColumnName("UseNumber");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.Quota).HasColumnName("Quota");
            this.Property(t => t.ToolIndex).HasColumnName("ToolIndex");
            this.Property(t => t.ToolLocation).HasColumnName("ToolLocation");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.NamingToolId).HasColumnName("NamingToolId");
            this.Property(t => t.ProcessWarehouseId).HasColumnName("ProcessWarehouseId");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductionTools)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.Tool)
                .WithMany(t => t.ProductionTools)
                .HasForeignKey(d => d.ToolId);
            this.HasRequired(t => t.Tool1)
                .WithMany(t => t.ProductionTools1)
                .HasForeignKey(d => d.NamingToolId);
            this.HasOptional(t => t.Warehouse)
                .WithMany(t => t.ProductionTools)
                .HasForeignKey(d => d.ProcessWarehouseId);

        }
    }
}
