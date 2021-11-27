using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class QuoteFormMap : EntityTypeConfiguration<QuoteForm>
    {
        public QuoteFormMap()
        {
            // Primary Key
            this.HasKey(t => t.QuoteId);

            // Properties
            this.Property(t => t.Note)
                .IsRequired();

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.QuoteNumber)
                .HasMaxLength(50);

            this.Property(t => t.CurrencyCode)
                .HasMaxLength(50);

            this.Property(t => t.PortName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QuoteForm", "Sales");
            this.Property(t => t.QuoteId).HasColumnName("QuoteId");
            this.Property(t => t.QuoteDate).HasColumnName("QuoteDate");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.PaymentMethodId).HasColumnName("PaymentMethodId");
            this.Property(t => t.DeliveryPeriodId).HasColumnName("DeliveryPeriodId");
            this.Property(t => t.OutOfDate).HasColumnName("OutOfDate");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.QuoteNumber).HasColumnName("QuoteNumber");
            this.Property(t => t.QuoteCount).HasColumnName("QuoteCount");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
            this.Property(t => t.PortName).HasColumnName("PortName");
            this.Property(t => t.ExchangeRate).HasColumnName("ExchangeRate");
            this.Property(t => t.DeliveryTerm).HasColumnName("DeliveryTerm");
            this.Property(t => t.PaymentCondition).HasColumnName("PaymentCondition");
            this.Property(t => t.SalesPersonId).HasColumnName("SalesPersonId");

            // Relationships
            this.HasRequired(t => t.Method)
                .WithMany(t => t.QuoteForms)
                .HasForeignKey(d => d.DeliveryPeriodId);
            this.HasRequired(t => t.Method1)
                .WithMany(t => t.QuoteForms1)
                .HasForeignKey(d => d.PaymentMethodId);
            this.HasOptional(t => t.Method2)
                .WithMany(t => t.QuoteForms2)
                .HasForeignKey(d => d.DeliveryTerm);
            this.HasOptional(t => t.Method3)
                .WithMany(t => t.QuoteForms3)
                .HasForeignKey(d => d.PaymentCondition);
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.QuoteForms)
                .HasForeignKey(d => d.CustomerId);
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.QuoteForms)
                .HasForeignKey(d => d.SalesPersonId);

        }
    }
}
