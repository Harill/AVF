using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ImportFormSX1Map : EntityTypeConfiguration<ImportFormSX1>
    {
        public ImportFormSX1Map()
        {
            // Primary Key
            this.HasKey(t => t.ImportId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.TransactionCode)
                .HasMaxLength(50);

            this.Property(t => t.Shift1Name)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Shift2Name)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ImportFormSX1", "Inv");
            this.Property(t => t.ImportId).HasColumnName("ImportId");
            this.Property(t => t.ImportDate).HasColumnName("ImportDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.TransactionCode).HasColumnName("TransactionCode");
            this.Property(t => t.Shift1Name).HasColumnName("Shift1Name");
            this.Property(t => t.Shift2Name).HasColumnName("Shift2Name");
            this.Property(t => t.MaterialUseDate).HasColumnName("MaterialUseDate");
            this.Property(t => t.AddWorkpieceMaterial).HasColumnName("AddWorkpieceMaterial");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
