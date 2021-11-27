using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MethodTypeMap : EntityTypeConfiguration<MethodType>
    {
        public MethodTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.TypeId);

            // Properties
            this.Property(t => t.TypeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MethodType", "Purchasing");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
