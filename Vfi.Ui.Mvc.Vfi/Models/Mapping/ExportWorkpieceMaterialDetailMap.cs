using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ExportWorkpieceMaterialDetailMap : EntityTypeConfiguration<ExportWorkpieceMaterialDetail>
    {
        public ExportWorkpieceMaterialDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.IdentityCode)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ExportWorkpieceMaterialDetail", "Inv");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ExportId).HasColumnName("ExportId");
            this.Property(t => t.IdentityCode).HasColumnName("IdentityCode");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasOptional(t => t.ExportWorkpieceMaterial)
                .WithMany(t => t.ExportWorkpieceMaterialDetails)
                .HasForeignKey(d => d.ExportId);

        }
    }
}
