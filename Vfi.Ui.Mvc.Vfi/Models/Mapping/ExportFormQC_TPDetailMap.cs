using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ExportFormQC_TPDetailMap : EntityTypeConfiguration<ExportFormQC_TPDetail>
    {
        public ExportFormQC_TPDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.Note)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ExportFormQC_TPDetail", "Inv");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ExportId).HasColumnName("ExportId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Box).HasColumnName("Box");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Number).HasColumnName("Number");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasOptional(t => t.ExportFormQC_TP)
                .WithMany(t => t.ExportFormQC_TPDetail)
                .HasForeignKey(d => d.ExportId);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.ExportFormQC_TPDetail)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
