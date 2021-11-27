using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class PoTaxInvoiceMap : EntityTypeConfiguration<PoTaxInvoice>
    {
        public PoTaxInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => t.TaxInvoiceId);

            // Properties
            this.Property(t => t.TaxInvoiceNumber)
                .HasMaxLength(50);

            this.Property(t => t.CurrencyCode)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PoTaxInvoice", "Purchasing");
            this.Property(t => t.TaxInvoiceId).HasColumnName("TaxInvoiceId");
            this.Property(t => t.TaxInvoiceNumber).HasColumnName("TaxInvoiceNumber");
            this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
            this.Property(t => t.ExchangeRate).HasColumnName("ExchangeRate");
            this.Property(t => t.ClassifiedId).HasColumnName("ClassifiedId");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.TaxPercent).HasColumnName("TaxPercent");
            this.Property(t => t.PoDate).HasColumnName("PoDate");

            // Relationships
            this.HasRequired(t => t.MaterialClassified)
                .WithMany(t => t.PoTaxInvoices)
                .HasForeignKey(d => d.ClassifiedId);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.PoTaxInvoices)
                .HasForeignKey(d => d.VendorId);

        }
    }
}
