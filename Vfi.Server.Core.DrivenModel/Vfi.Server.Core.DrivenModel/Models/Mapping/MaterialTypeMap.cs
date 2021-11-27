using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class MaterialTypeMap : EntityTypeConfiguration<MaterialType>
    {
        public MaterialTypeMap()
        {
            // Primary Key
            HasKey(t => t.MaterialTypeId);

            // Properties
            Property(t => t.MaterialTypeName)
                .HasMaxLength(50);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("MaterialType", "Production");
            Property(t => t.MaterialTypeId).HasColumnName("MaterialTypeId");
            Property(t => t.MaterialClassifiedId).HasColumnName("MaterialClassifiedId");
            Property(t => t.MaterialTypeName).HasColumnName("MaterialTypeName");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.MaterialClassified)
                .WithMany(t => t.MaterialTypes)
                .HasForeignKey(d => d.MaterialClassifiedId);

        }
    }
}
