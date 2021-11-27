using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ExportWorkpieceMaterialMap : EntityTypeConfiguration<ExportWorkpieceMaterial>
    {
        public ExportWorkpieceMaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.ExportId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ExportWorkpieceMaterial", "Inv");
            this.Property(t => t.ExportId).HasColumnName("ExportId");
            this.Property(t => t.ExportDate).HasColumnName("ExportDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
        }
    }
}
