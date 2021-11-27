using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ForecastOrderMap : EntityTypeConfiguration<ForecastOrder>
    {
        public ForecastOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.ForecastOrderId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ForecastOrder", "Sales");
            this.Property(t => t.ForecastOrderId).HasColumnName("ForecastOrderId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ForecastDate).HasColumnName("ForecastDate");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.MaterialEnoughDate).HasColumnName("MaterialEnoughDate");
            this.Property(t => t.IsSelling).HasColumnName("IsSelling");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ForecastOrders)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
