using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class TaxInvoiceDetailMap : EntityTypeConfiguration<TaxInvoiceDetail>
    {
        public TaxInvoiceDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TaxInvoiceDetail", "Sales");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TaxInvoiceId).HasColumnName("TaxInvoiceId");
            this.Property(t => t.Money).HasColumnName("Money");
            this.Property(t => t.Times).HasColumnName("Times");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ImportDate).HasColumnName("ImportDate");

            // Relationships
            this.HasOptional(t => t.TaxInvoice)
                .WithMany(t => t.TaxInvoiceDetails)
                .HasForeignKey(d => d.TaxInvoiceId);

        }
    }
}
