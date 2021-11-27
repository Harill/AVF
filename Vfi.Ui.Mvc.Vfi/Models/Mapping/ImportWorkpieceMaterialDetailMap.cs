using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ImportWorkpieceMaterialDetailMap : EntityTypeConfiguration<ImportWorkpieceMaterialDetail>
    {
        public ImportWorkpieceMaterialDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.IdentityCode)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ImportWorkpieceMaterialDetail", "Inv");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ImportId).HasColumnName("ImportId");
            this.Property(t => t.IdentityCode).HasColumnName("IdentityCode");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasOptional(t => t.ImportWorkpieceMaterial)
                .WithMany(t => t.ImportWorkpieceMaterialDetails)
                .HasForeignKey(d => d.ImportId);

        }
    }
}
