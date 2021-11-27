using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SectionLogMap : EntityTypeConfiguration<SectionLog>
    {
        public SectionLogMap()
        {
            // Primary Key
            this.HasKey(t => t.LogId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SectionLog", "Factory");
            this.Property(t => t.LogId).HasColumnName("LogId");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ProductionSectionId).HasColumnName("ProductionSectionId");
            this.Property(t => t.NewProductivity).HasColumnName("NewProductivity");
            this.Property(t => t.OldProductivity).HasColumnName("OldProductivity");

            // Relationships
            this.HasRequired(t => t.ProductionSection)
                .WithMany(t => t.SectionLogs)
                .HasForeignKey(d => d.ProductionSectionId);

        }
    }
}
