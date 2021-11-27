using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ImportWorkpieceMaterialMap : EntityTypeConfiguration<ImportWorkpieceMaterial>
    {
        public ImportWorkpieceMaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.ImportId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ImportWorkpieceMaterial", "Inv");
            this.Property(t => t.ImportId).HasColumnName("ImportId");
            this.Property(t => t.ImportSx1Id).HasColumnName("ImportSx1Id");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.ImportDate).HasColumnName("ImportDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.ImportFormSX1)
                .WithMany(t => t.ImportWorkpieceMaterials)
                .HasForeignKey(d => d.ImportSx1Id);
            this.HasOptional(t => t.Transaction)
                .WithMany(t => t.ImportWorkpieceMaterials)
                .HasForeignKey(d => d.TransactionId);

        }
    }
}
