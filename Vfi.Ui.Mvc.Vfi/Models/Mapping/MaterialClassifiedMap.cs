using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MaterialClassifiedMap : EntityTypeConfiguration<MaterialClassified>
    {
        public MaterialClassifiedMap()
        {
            // Primary Key
            this.HasKey(t => t.MaterialClassifiedId);

            // Properties
            this.Property(t => t.MaterialClassifiedName)
                .HasMaxLength(255);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaterialClassified", "Production");
            this.Property(t => t.MaterialClassifiedId).HasColumnName("MaterialClassifiedId");
            this.Property(t => t.MaterialClassifiedName).HasColumnName("MaterialClassifiedName");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
