using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MaterialTypeMap : EntityTypeConfiguration<MaterialType>
    {
        public MaterialTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.MaterialTypeId);

            // Properties
            this.Property(t => t.MaterialTypeName)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.IdentityCode)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("MaterialType", "Production");
            this.Property(t => t.MaterialTypeId).HasColumnName("MaterialTypeId");
            this.Property(t => t.MaterialClassifiedId).HasColumnName("MaterialClassifiedId");
            this.Property(t => t.MaterialTypeName).HasColumnName("MaterialTypeName");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.IdentityCode).HasColumnName("IdentityCode");

            // Relationships
            this.HasRequired(t => t.MaterialClassified)
                .WithMany(t => t.MaterialTypes)
                .HasForeignKey(d => d.MaterialClassifiedId);

        }
    }
}
