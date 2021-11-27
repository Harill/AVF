using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class TaxInvoiceProductDetailMap : EntityTypeConfiguration<TaxInvoiceProductDetail>
    {
        public TaxInvoiceProductDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.PDetailId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TaxInvoiceProductDetail", "Sales");
            this.Property(t => t.PDetailId).HasColumnName("PDetailId");
            this.Property(t => t.ExportDetailId).HasColumnName("ExportDetailId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.TaxInvoiceId).HasColumnName("TaxInvoiceId");
            this.Property(t => t.ExportDate).HasColumnName("ExportDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.ExportFormTP_KDDetail)
                .WithMany(t => t.TaxInvoiceProductDetails)
                .HasForeignKey(d => d.ExportDetailId);
            this.HasOptional(t => t.TaxInvoice)
                .WithMany(t => t.TaxInvoiceProductDetails)
                .HasForeignKey(d => d.TaxInvoiceId);

        }
    }
}
