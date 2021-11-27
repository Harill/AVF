using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class DefectInventoryMap : EntityTypeConfiguration<DefectInventory>
    {
        public DefectInventoryMap()
        {
            // Primary Key
            this.HasKey(t => t.InvId);

            // Properties
            // Table & Column Mappings
            this.ToTable("DefectInventory", "Factory");
            this.Property(t => t.InvId).HasColumnName("InvId");
            this.Property(t => t.TotalQuantity).HasColumnName("TotalQuantity");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.DefectId).HasColumnName("DefectId");

            // Relationships
            this.HasRequired(t => t.ProductionDefect)
                .WithMany(t => t.DefectInventories)
                .HasForeignKey(d => d.DefectId);

        }
    }
}
