using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ExportToolMap : EntityTypeConfiguration<ExportTool>
    {
        public ExportToolMap()
        {
            // Primary Key
            this.HasKey(t => t.ExportId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.Department)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ExportTool", "Inv");
            this.Property(t => t.ExportId).HasColumnName("ExportId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.ExportDate).HasColumnName("ExportDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ProductId).HasColumnName("ProductId");

            // Relationships
            this.HasOptional(t => t.TransactionFpt)
                .WithMany(t => t.ExportTools)
                .HasForeignKey(d => d.TransactionId);

        }
    }
}
