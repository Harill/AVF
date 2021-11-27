using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ForecastOrderDetailMap : EntityTypeConfiguration<ForecastOrderDetail>
    {
        public ForecastOrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ForecastOrderDetail", "Sales");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ForecastOrderId).HasColumnName("ForecastOrderId");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.ForecastQuantity).HasColumnName("ForecastQuantity");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.IsWorking).HasColumnName("IsWorking");

            // Relationships
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.ForecastOrderDetails)
                .HasForeignKey(d => d.WarehouseId);
            this.HasRequired(t => t.ForecastOrder)
                .WithMany(t => t.ForecastOrderDetails)
                .HasForeignKey(d => d.ForecastOrderId);

        }
    }
}
