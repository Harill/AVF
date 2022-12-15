using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MaterialQuoteBaseDetailMap : EntityTypeConfiguration<MaterialQuoteBaseDetail>
    {
        public MaterialQuoteBaseDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            // Table & Column Mappings
            this.ToTable("MaterialQuoteBaseDetail", "Production");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.MaterialQuoteBaseId).HasColumnName("MaterialQuoteBaseId");
            this.Property(t => t.FromOutDiameter).HasColumnName("FromOutDiameter");
            this.Property(t => t.ToOutDiameter).HasColumnName("ToOutDiameter");
            this.Property(t => t.InDiameter).HasColumnName("InDiameter");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.MaterialQuoteBase)
                .WithMany(t => t.MaterialQuoteBaseDetails)
                .HasForeignKey(d => d.MaterialQuoteBaseId);

        }
    }
}
