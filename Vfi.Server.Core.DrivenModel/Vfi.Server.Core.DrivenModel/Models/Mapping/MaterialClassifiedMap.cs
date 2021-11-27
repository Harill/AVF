using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class MaterialClassifiedMap : EntityTypeConfiguration<MaterialClassified>
    {
        public MaterialClassifiedMap()
        {
            // Primary Key
            HasKey(t => t.MaterialClassifiedId);

            // Properties
            Property(t => t.MaterialClassifiedName)
                .HasMaxLength(255);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("MaterialClassified", "Production");
            Property(t => t.MaterialClassifiedId).HasColumnName("MaterialClassifiedId");
            Property(t => t.MaterialClassifiedName).HasColumnName("MaterialClassifiedName");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
