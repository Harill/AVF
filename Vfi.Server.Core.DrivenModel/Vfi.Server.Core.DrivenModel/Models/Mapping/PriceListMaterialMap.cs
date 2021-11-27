using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class PriceListMaterialMap : EntityTypeConfiguration<PriceListMaterial>
    {
        public PriceListMaterialMap()
        {
            // Primary Key
            HasKey(t => t.PriceListMaterialId);

            // Properties
            Property(t => t.Currency)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("PriceListMaterial", "Purchasing");
            Property(t => t.PriceListMaterialId).HasColumnName("PriceListMaterialId");
            Property(t => t.MaterialId).HasColumnName("MaterialId");
            Property(t => t.NetPrice).HasColumnName("NetPrice");
            Property(t => t.Currency).HasColumnName("Currency");
            Property(t => t.Exchange).HasColumnName("Exchange");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Currency1)
                .WithMany(t => t.PriceListMaterials)
                .HasForeignKey(d => d.Currency);
            HasRequired(t => t.Material)
                .WithMany(t => t.PriceListMaterials)
                .HasForeignKey(d => d.MaterialId);

        }
    }
}
