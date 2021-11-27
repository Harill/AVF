using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class PoTaxInvoiceMoneyMap : EntityTypeConfiguration<PoTaxInvoiceMoney>
    {
        public PoTaxInvoiceMoneyMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PoTaxInvoiceMoney", "Purchasing");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.TaxInvoiceId).HasColumnName("TaxInvoiceId");
            this.Property(t => t.Money).HasColumnName("Money");
            this.Property(t => t.Times).HasColumnName("Times");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ImportDate).HasColumnName("ImportDate");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasRequired(t => t.PoTaxInvoice)
                .WithMany(t => t.PoTaxInvoiceMoneys)
                .HasForeignKey(d => d.TaxInvoiceId);

        }
    }
}
