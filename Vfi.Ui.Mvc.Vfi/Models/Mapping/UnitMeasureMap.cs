using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class UnitMeasureMap : EntityTypeConfiguration<UnitMeasure>
    {
        public UnitMeasureMap()
        {
            // Primary Key
            this.HasKey(t => t.UnitId);

            // Properties
            this.Property(t => t.UnitCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UnitName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UnitMeasure", "Production");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.UnitCode).HasColumnName("UnitCode");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.IsPlatingUnit).HasColumnName("IsPlatingUnit");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
        }
    }
}
