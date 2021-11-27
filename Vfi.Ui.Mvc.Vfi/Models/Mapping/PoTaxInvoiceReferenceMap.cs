using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class PoTaxInvoiceReferenceMap : EntityTypeConfiguration<PoTaxInvoiceReference>
    {
        public PoTaxInvoiceReferenceMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.Unit)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PoTaxInvoiceReference", "Purchasing");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.TaxInvoiceId).HasColumnName("TaxInvoiceId");
            this.Property(t => t.ReferenceId).HasColumnName("ReferenceId");
            this.Property(t => t.ClassifiedId).HasColumnName("ClassifiedId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Unit).HasColumnName("Unit");

            // Relationships
            this.HasRequired(t => t.PoTaxInvoice)
                .WithMany(t => t.PoTaxInvoiceReferences)
                .HasForeignKey(d => d.TaxInvoiceId);

        }
    }
}
