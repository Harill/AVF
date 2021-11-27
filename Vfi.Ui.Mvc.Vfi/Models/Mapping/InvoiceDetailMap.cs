using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class InvoiceDetailMap : EntityTypeConfiguration<InvoiceDetail>
    {
        public InvoiceDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.InvoiceDetailId);

            // Properties
            this.Property(t => t.Note)
                .HasMaxLength(500);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InvoiceDetail", "Sales");
            this.Property(t => t.InvoiceDetailId).HasColumnName("InvoiceDetailId");
            this.Property(t => t.InvoiceId).HasColumnName("InvoiceId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Piece).HasColumnName("Piece");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.OrderDetailId).HasColumnName("OrderDetailId");
            this.Property(t => t.ExportDetailId).HasColumnName("ExportDetailId");
            this.Property(t => t.NoteDetailId).HasColumnName("NoteDetailId");

            // Relationships
            this.HasOptional(t => t.ExportFormTP_KDDetail)
                .WithMany(t => t.InvoiceDetails)
                .HasForeignKey(d => d.ExportDetailId);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.InvoiceDetails)
                .HasForeignKey(d => d.ProductId);
            this.HasOptional(t => t.Invoice)
                .WithMany(t => t.InvoiceDetails)
                .HasForeignKey(d => d.InvoiceId);
            this.HasOptional(t => t.OrderDetail)
                .WithMany(t => t.InvoiceDetails)
                .HasForeignKey(d => d.OrderDetailId);
            this.HasOptional(t => t.OrderNoteDetail)
                .WithMany(t => t.InvoiceDetails)
                .HasForeignKey(d => d.NoteDetailId);

        }
    }
}
