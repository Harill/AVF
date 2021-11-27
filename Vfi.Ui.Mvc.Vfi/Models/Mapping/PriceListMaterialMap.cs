using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class PriceListMaterialMap : EntityTypeConfiguration<PriceListMaterial>
    {
        public PriceListMaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.PriceListMaterialId);

            // Properties
            this.Property(t => t.Currency)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PriceListMaterial", "Purchasing");
            this.Property(t => t.PriceListMaterialId).HasColumnName("PriceListMaterialId");
            this.Property(t => t.MaterialId).HasColumnName("MaterialId");
            this.Property(t => t.NetPrice).HasColumnName("NetPrice");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.Exchange).HasColumnName("Exchange");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Currency1)
                .WithMany(t => t.PriceListMaterials)
                .HasForeignKey(d => d.Currency);
            this.HasRequired(t => t.Material)
                .WithMany(t => t.PriceListMaterials)
                .HasForeignKey(d => d.MaterialId);

        }
    }
}
