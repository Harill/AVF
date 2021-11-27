using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class TransactionProductMap : EntityTypeConfiguration<TransactionProduct>
    {
        public TransactionProductMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            // Table & Column Mappings
            this.ToTable("TransactionProduct", "Inv");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.QuantityKg).HasColumnName("QuantityKg");
            this.Property(t => t.ProductId).HasColumnName("ProductId");

            // Relationships
            this.HasRequired(t => t.Transaction)
                .WithMany(t => t.TransactionProducts)
                .HasForeignKey(d => d.TransactionId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.TransactionProducts)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
