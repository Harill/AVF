using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MaterialMap : EntityTypeConfiguration<Material>
    {
        public MaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.MaterialId);

            // Properties
            this.Property(t => t.MaterialCode)
                .HasMaxLength(50);

            this.Property(t => t.MaterialName)
                .HasMaxLength(255);

            this.Property(t => t.DiameterType)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.Shape)
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("Material", "Production");
            this.Property(t => t.MaterialId).HasColumnName("MaterialId");
            this.Property(t => t.MaterialTypeId).HasColumnName("MaterialTypeId");
            this.Property(t => t.MaterialCode).HasColumnName("MaterialCode");
            this.Property(t => t.MaterialName).HasColumnName("MaterialName");
            this.Property(t => t.DiameterType).HasColumnName("DiameterType");
            this.Property(t => t.Length).HasColumnName("Length");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Shape).HasColumnName("Shape");
            this.Property(t => t.OutDiameter).HasColumnName("OutDiameter");
            this.Property(t => t.InDiameter).HasColumnName("InDiameter");
            this.Property(t => t.IsExpensive).HasColumnName("IsExpensive");

            // Relationships
            this.HasRequired(t => t.MaterialType)
                .WithMany(t => t.Materials)
                .HasForeignKey(d => d.MaterialTypeId);

        }
    }
}
