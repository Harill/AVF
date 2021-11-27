using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class OrderNoteDetailMap : EntityTypeConfiguration<OrderNoteDetail>
    {
        public OrderNoteDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.NoteDetailId);

            // Properties
            // Table & Column Mappings
            this.ToTable("OrderNoteDetail", "Sales");
            this.Property(t => t.NoteDetailId).HasColumnName("NoteDetailId");
            this.Property(t => t.NoteId).HasColumnName("NoteId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Weight).HasColumnName("Weight");

            // Relationships
            this.HasOptional(t => t.OrderNote)
                .WithMany(t => t.OrderNoteDetails)
                .HasForeignKey(d => d.NoteId);

        }
    }
}
