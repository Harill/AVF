using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SelectGroupProductPeriodMap : EntityTypeConfiguration<SelectGroupProductPeriod>
    {
        public SelectGroupProductPeriodMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductId, t.WarehouseId });

            // Properties
            this.Property(t => t.ProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WarehouseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SelectGroupProductPeriod");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.TotalPeriod).HasColumnName("TotalPeriod");
        }
    }
}
