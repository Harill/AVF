using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class PlatingFormMap : EntityTypeConfiguration<PlatingForm>
    {
        public PlatingFormMap()
        {
            // Primary Key
            this.HasKey(t => t.FormId);

            // Properties
            this.Property(t => t.PlatingFormNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CurrencyCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Note)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("PlatingForm", "Purchasing");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.PlatingFormNumber).HasColumnName("PlatingFormNumber");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
            this.Property(t => t.ExchangeRate).HasColumnName("ExchangeRate");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.PlatingType).HasColumnName("PlatingType");

            // Relationships
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.PlatingForms)
                .HasForeignKey(d => d.VendorId);

        }
    }
}
