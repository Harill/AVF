using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class TaxInvoiceProductMap : EntityTypeConfiguration<TaxInvoiceProduct>
    {
        public TaxInvoiceProductMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            // Table & Column Mappings
            this.ToTable("TaxInvoiceProduct", "Sales");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.TaxInvoiceId).HasColumnName("TaxInvoiceId");
            this.Property(t => t.IsFinish).HasColumnName("IsFinish");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.TaxInvoiceProducts)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.TaxInvoice)
                .WithMany(t => t.TaxInvoiceProducts)
                .HasForeignKey(d => d.TaxInvoiceId);

        }
    }
}
