using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class InvoiceDetailMap : EntityTypeConfiguration<InvoiceDetail>
    {
        public InvoiceDetailMap()
        {
            // Primary Key
            HasKey(t => t.InvoiceDetailId);

            // Properties
            Property(t => t.Note)
                .HasMaxLength(500);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("InvoiceDetail", "Sales");
            Property(t => t.InvoiceDetailId).HasColumnName("InvoiceDetailId");
            Property(t => t.InvoiceId).HasColumnName("InvoiceId");
            Property(t => t.ProductId).HasColumnName("ProductId");
            Property(t => t.ProductDespatchNoteId).HasColumnName("ProductDespatchNoteId");
            Property(t => t.ProductLength).HasColumnName("ProductLength");
            Property(t => t.Bundle).HasColumnName("Bundle");
            Property(t => t.Piece).HasColumnName("Piece");
            Property(t => t.Weight).HasColumnName("Weight");
            Property(t => t.Price).HasColumnName("Price");
            Property(t => t.Amount).HasColumnName("Amount");
            Property(t => t.VatAmount).HasColumnName("VatAmount");
            Property(t => t.TotalAmount).HasColumnName("TotalAmount");
            Property(t => t.RemainedBundle).HasColumnName("RemainedBundle");
            Property(t => t.RemainedWeight).HasColumnName("RemainedWeight");
            Property(t => t.RemainedPiece).HasColumnName("RemainedPiece");
            Property(t => t.Note).HasColumnName("Note");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasOptional(t => t.Product)
                .WithMany(t => t.InvoiceDetails)
                .HasForeignKey(d => d.ProductId);
            HasOptional(t => t.Invoice)
                .WithMany(t => t.InvoiceDetails)
                .HasForeignKey(d => d.InvoiceId);

        }
    }
}
