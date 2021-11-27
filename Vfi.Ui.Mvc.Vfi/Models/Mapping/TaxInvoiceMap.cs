using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class TaxInvoiceMap : EntityTypeConfiguration<TaxInvoice>
    {
        public TaxInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TaxInvoiceList)
                .HasMaxLength(50);

            this.Property(t => t.Currency)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TaxInvoice", "Sales");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TaxInvoiceList).HasColumnName("TaxInvoiceList");
            this.Property(t => t.TotalAmount).HasColumnName("TotalAmount");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.InvoiceId).HasColumnName("InvoiceId");
            this.Property(t => t.SetupDate).HasColumnName("SetupDate");
            this.Property(t => t.TaxPercent).HasColumnName("TaxPercent");
            this.Property(t => t.ExchangeRate).HasColumnName("ExchangeRate");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.FinishDate).HasColumnName("FinishDate");

            // Relationships
            this.HasOptional(t => t.Customer)
                .WithMany(t => t.TaxInvoices)
                .HasForeignKey(d => d.CustomerId);

        }
    }
}
