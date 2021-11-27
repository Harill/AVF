using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ExportMaterialMap : EntityTypeConfiguration<ExportMaterial>
    {
        public ExportMaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.ExportId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.ShiftName)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ExportMaterial", "Inv");
            this.Property(t => t.ExportId).HasColumnName("ExportId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.ExportDate).HasColumnName("ExportDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ShiftName).HasColumnName("ShiftName");
            this.Property(t => t.ShiftType).HasColumnName("ShiftType");

            // Relationships
            this.HasOptional(t => t.Transaction)
                .WithMany(t => t.ExportMaterials)
                .HasForeignKey(d => d.TransactionId);

        }
    }
}
