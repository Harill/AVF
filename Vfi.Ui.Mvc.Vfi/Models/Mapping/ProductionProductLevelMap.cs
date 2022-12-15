using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionProductLevelMap : EntityTypeConfiguration<ProductionProductLevel>
    {
        public ProductionProductLevelMap()
        {
            // Primary Key
            this.HasKey(t => t.LevelId);

            // Properties
            this.Property(t => t.LevelName)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionProductLevel", "Factory");
            this.Property(t => t.LevelId).HasColumnName("LevelId");
            this.Property(t => t.LevelName).HasColumnName("LevelName");
            this.Property(t => t.Factor).HasColumnName("Factor");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
        }
    }
}
