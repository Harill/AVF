using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionProductivityQuoteBaseMap : EntityTypeConfiguration<ProductionProductivityQuoteBase>
    {
        public ProductionProductivityQuoteBaseMap()
        {
            // Primary Key
            this.HasKey(t => t.BaseId);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionProductivityQuoteBase", "Factory");
            this.Property(t => t.BaseId).HasColumnName("BaseId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Round).HasColumnName("Round");
            this.Property(t => t.L).HasColumnName("L");
            this.Property(t => t.F).HasColumnName("F");
            this.Property(t => t.Time).HasColumnName("Time");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductionProductivityQuoteBases)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
