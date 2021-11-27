using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SectionMap : EntityTypeConfiguration<Section>
    {
        public SectionMap()
        {
            // Primary Key
            this.HasKey(t => t.SectionId);

            // Properties
            this.Property(t => t.SectionName)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Section", "Factory");
            this.Property(t => t.SectionId).HasColumnName("SectionId");
            this.Property(t => t.SectionName).HasColumnName("SectionName");
            this.Property(t => t.SaleFactor).HasColumnName("SaleFactor");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
