using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MaterialQuoteBaseMap : EntityTypeConfiguration<MaterialQuoteBase>
    {
        public MaterialQuoteBaseMap()
        {
            // Primary Key
            this.HasKey(t => t.BaseId);

            // Properties
            this.Property(t => t.MaterialName)
                .HasMaxLength(50);

            this.Property(t => t.MaterialShape)
                .HasMaxLength(50);

            this.Property(t => t.MaterialDiameterType)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaterialQuoteBase", "Production");
            this.Property(t => t.BaseId).HasColumnName("BaseId");
            this.Property(t => t.MaterialTypeId).HasColumnName("MaterialTypeId");
            this.Property(t => t.MaterialName).HasColumnName("MaterialName");
            this.Property(t => t.MaterialShape).HasColumnName("MaterialShape");
            this.Property(t => t.MaterialDiameterType).HasColumnName("MaterialDiameterType");
            this.Property(t => t.BasePrice).HasColumnName("BasePrice");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasRequired(t => t.MaterialType)
                .WithMany(t => t.MaterialQuoteBases)
                .HasForeignKey(d => d.MaterialTypeId);

        }
    }
}
