using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class PoTaxInvoiceReferenceDetailMap : EntityTypeConfiguration<PoTaxInvoiceReferenceDetail>
    {
        public PoTaxInvoiceReferenceDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.Unit)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PoTaxInvoiceReferenceDetail", "Purchasing");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.DetailReferenceId).HasColumnName("DetailReferenceId");
            this.Property(t => t.ReferenceId).HasColumnName("ReferenceId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.ImportId).HasColumnName("ImportId");
            this.Property(t => t.ImportDetailId).HasColumnName("ImportDetailId");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasRequired(t => t.PoTaxInvoiceReference)
                .WithMany(t => t.PoTaxInvoiceReferenceDetails)
                .HasForeignKey(d => d.DetailReferenceId);

        }
    }
}
