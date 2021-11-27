using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ExportChangeProductMap : EntityTypeConfiguration<ExportChangeProduct>
    {
        public ExportChangeProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ExportChangeId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.Transporter)
                .HasMaxLength(50);

            this.Property(t => t.CompanyTransport)
                .HasMaxLength(50);

            this.Property(t => t.CarNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ExportChangeProduct", "Inv");
            this.Property(t => t.ExportChangeId).HasColumnName("ExportChangeId");
            this.Property(t => t.NoteId).HasColumnName("NoteId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ExportDate).HasColumnName("ExportDate");
            this.Property(t => t.Transporter).HasColumnName("Transporter");
            this.Property(t => t.CompanyTransport).HasColumnName("CompanyTransport");
            this.Property(t => t.CarNumber).HasColumnName("CarNumber");
            this.Property(t => t.Totalbox).HasColumnName("Totalbox");

            // Relationships
            this.HasOptional(t => t.OrderNote)
                .WithMany(t => t.ExportChangeProducts)
                .HasForeignKey(d => d.NoteId);
            this.HasOptional(t => t.Transaction)
                .WithMany(t => t.ExportChangeProducts)
                .HasForeignKey(d => d.TransactionId);

        }
    }
}
