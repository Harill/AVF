using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ForecastMap : EntityTypeConfiguration<Forecast>
    {
        public ForecastMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Forecasts", "Production");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ForecastsQuality).HasColumnName("ForecastsQuality");
            this.Property(t => t.DateModified).HasColumnName("DateModified");
        }
    }
}
