using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionPricingMap : EntityTypeConfiguration<ProductionPricing>
    {
        public ProductionPricingMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionPricing", "Factory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductionCamesPricing).HasColumnName("ProductionCamesPricing");
            this.Property(t => t.ProductionCncPricing).HasColumnName("ProductionCncPricing");
            this.Property(t => t.CncPricing).HasColumnName("CncPricing");
            this.Property(t => t.Production2Pricing).HasColumnName("Production2Pricing");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ProductionTeamDPricing).HasColumnName("ProductionTeamDPricing");
            this.Property(t => t.ProductionTechnicalPricing).HasColumnName("ProductionTechnicalPricing");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductionPricings)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
