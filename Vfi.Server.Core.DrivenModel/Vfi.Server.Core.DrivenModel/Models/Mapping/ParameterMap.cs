using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class ParameterMap : EntityTypeConfiguration<Parameter>
    {
        public ParameterMap()
        {
            // Primary Key
            HasKey(t => t.ParamId);

            // Properties
            Property(t => t.ParamCode)
                .HasMaxLength(50);

            Property(t => t.Name)
                .HasMaxLength(50);

            Property(t => t.Value)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Parameter", "System");
            Property(t => t.ParamId).HasColumnName("ParamId");
            Property(t => t.ParamCode).HasColumnName("ParamCode");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Value).HasColumnName("Value");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
