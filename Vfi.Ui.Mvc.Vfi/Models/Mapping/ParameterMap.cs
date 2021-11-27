using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ParameterMap : EntityTypeConfiguration<Parameter>
    {
        public ParameterMap()
        {
            // Primary Key
            this.HasKey(t => t.ParamId);

            // Properties
            this.Property(t => t.ParamCode)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Parameter", "System");
            this.Property(t => t.ParamId).HasColumnName("ParamId");
            this.Property(t => t.ParamCode).HasColumnName("ParamCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
