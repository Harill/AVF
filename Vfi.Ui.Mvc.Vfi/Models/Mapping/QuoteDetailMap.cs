using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class QuoteDetailMap : EntityTypeConfiguration<QuoteDetail>
    {
        public QuoteDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.MaterialDesign)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Dimension)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QuoteDetail", "Sales");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Diff).HasColumnName("Diff");
            this.Property(t => t.MaterialPrice).HasColumnName("MaterialPrice");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.QuoteId).HasColumnName("QuoteId");
            this.Property(t => t.QuoteCost).HasColumnName("QuoteCost");
            this.Property(t => t.ProcessingCost).HasColumnName("ProcessingCost");
            this.Property(t => t.ProductWeight).HasColumnName("ProductWeight");
            this.Property(t => t.MaterialDesign).HasColumnName("MaterialDesign");
            this.Property(t => t.Dimension).HasColumnName("Dimension");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.QuoteDetails)
                .HasForeignKey(d => d.ProductId);
            this.HasOptional(t => t.QuoteForm)
                .WithMany(t => t.QuoteDetails)
                .HasForeignKey(d => d.QuoteId);

        }
    }
}
