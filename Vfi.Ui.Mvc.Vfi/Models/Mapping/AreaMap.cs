using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class AreaMap : EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {
            // Primary Key
            this.HasKey(t => t.AreaId);

            // Properties
            this.Property(t => t.AreaName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Area", "Sales");
            this.Property(t => t.AreaId).HasColumnName("AreaId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.AreaName).HasColumnName("AreaName");
        }
    }
}
