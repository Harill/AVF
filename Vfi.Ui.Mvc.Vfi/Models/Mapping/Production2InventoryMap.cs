using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class Production2InventoryMap : EntityTypeConfiguration<Production2Inventory>
    {
        public Production2InventoryMap()
        {
            // Primary Key
            this.HasKey(t => t.InvId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Production2Inventory", "Factory");
            this.Property(t => t.InvId).HasColumnName("InvId");
            this.Property(t => t.TotalQuantity).HasColumnName("TotalQuantity");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.ProductionSectionId).HasColumnName("ProductionSectionId");

            // Relationships
            this.HasOptional(t => t.ProductionSection)
                .WithMany(t => t.Production2Inventory)
                .HasForeignKey(d => d.ProductionSectionId);

        }
    }
}
