using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SectionProcessInventoryMap : EntityTypeConfiguration<SectionProcessInventory>
    {
        public SectionProcessInventoryMap()
        {
            // Primary Key
            this.HasKey(t => t.InvId);

            // Properties
            // Table & Column Mappings
            this.ToTable("SectionProcessInventory", "Factory");
            this.Property(t => t.InvId).HasColumnName("InvId");
            this.Property(t => t.ProcessId).HasColumnName("ProcessId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.TotalInv).HasColumnName("TotalInv");
            this.Property(t => t.UnitWeight).HasColumnName("UnitWeight");
            this.Property(t => t.LotNumber).HasColumnName("LotNumber");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.SectionProcess)
                .WithMany(t => t.SectionProcessInventories)
                .HasForeignKey(d => d.ProcessId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.SectionProcessInventories)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
