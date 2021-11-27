using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionMaterialMap : EntityTypeConfiguration<ProductionMaterial>
    {
        public ProductionMaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.RealMaterialId);

            // Properties
            this.Property(t => t.Note)
                .IsRequired();

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionMaterial", "Factory");
            this.Property(t => t.RealMaterialId).HasColumnName("RealMaterialId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.MaterialId).HasColumnName("MaterialId");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.UnitWeightByMaterial).HasColumnName("UnitWeightByMaterial");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasRequired(t => t.Material)
                .WithMany(t => t.ProductionMaterials)
                .HasForeignKey(d => d.MaterialId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductionMaterials)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
