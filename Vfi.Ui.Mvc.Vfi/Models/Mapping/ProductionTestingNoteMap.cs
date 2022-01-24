using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionTestingNoteMap : EntityTypeConfiguration<ProductionTestingNote>
    {
        public ProductionTestingNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.NoteId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionTestingNote", "Factory");
            this.Property(t => t.NoteId).HasColumnName("NoteId");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ProductId).HasColumnName("ProductId");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductionTestingNotes)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.ProductionTestingNotes)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
