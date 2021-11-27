using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class MaterialMap : EntityTypeConfiguration<Material>
    {
        public MaterialMap()
        {
            // Primary Key
            HasKey(t => t.MaterialId);

            // Properties
            Property(t => t.MaterialCode)
                .HasMaxLength(50);

            Property(t => t.MaterialName)
                .HasMaxLength(255);

            Property(t => t.Diameter)
                .HasMaxLength(50);

            Property(t => t.DiameterType)
                .HasMaxLength(50);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Material", "Production");
            Property(t => t.MaterialId).HasColumnName("MaterialId");
            Property(t => t.MaterialTypeId).HasColumnName("MaterialTypeId");
            Property(t => t.MaterialCode).HasColumnName("MaterialCode");
            Property(t => t.MaterialName).HasColumnName("MaterialName");
            Property(t => t.Diameter).HasColumnName("Diameter");
            Property(t => t.DiameterType).HasColumnName("DiameterType");
            Property(t => t.Length).HasColumnName("Length");
            Property(t => t.Weight).HasColumnName("Weight");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.MaterialType)
                .WithMany(t => t.Materials)
                .HasForeignKey(d => d.MaterialTypeId);

        }
    }
}
