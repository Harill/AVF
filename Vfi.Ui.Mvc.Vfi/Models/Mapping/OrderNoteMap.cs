using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class OrderNoteMap : EntityTypeConfiguration<OrderNote>
    {
        public OrderNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.NoteId);

            // Properties
            this.Property(t => t.NoteNumber)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrderNote", "Sales");
            this.Property(t => t.NoteId).HasColumnName("NoteId");
            this.Property(t => t.NoteNumber).HasColumnName("NoteNumber");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.NoteType).HasColumnName("NoteType");
            this.Property(t => t.InvoiceId).HasColumnName("InvoiceId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.ExportId).HasColumnName("ExportId");
            this.Property(t => t.IsComplete).HasColumnName("IsComplete");

            // Relationships
            this.HasOptional(t => t.ExportFormTP_KD)
                .WithMany(t => t.OrderNotes)
                .HasForeignKey(d => d.ExportId);
            this.HasOptional(t => t.Transaction)
                .WithMany(t => t.OrderNotes)
                .HasForeignKey(d => d.TransactionId);
            this.HasOptional(t => t.Invoice)
                .WithMany(t => t.OrderNotes)
                .HasForeignKey(d => d.InvoiceId);

        }
    }
}
