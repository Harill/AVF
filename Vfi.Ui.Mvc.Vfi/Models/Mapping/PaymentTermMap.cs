using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class PaymentTermMap : EntityTypeConfiguration<PaymentTerm>
    {
        public PaymentTermMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TermName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PaymentTerm", "Sales");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TermName).HasColumnName("TermName");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
