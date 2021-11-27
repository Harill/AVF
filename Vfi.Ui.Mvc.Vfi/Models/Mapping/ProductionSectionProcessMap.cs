using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionSectionProcessMap : EntityTypeConfiguration<ProductionSectionProcess>
    {
        public ProductionSectionProcessMap()
        {
            // Primary Key
            this.HasKey(t => t.PSPId);

            // Properties
            this.Property(t => t.UnitMeasure)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionSectionProcess", "Factory");
            this.Property(t => t.PSPId).HasColumnName("PSPId");
            this.Property(t => t.ProcessId).HasColumnName("ProcessId");
            this.Property(t => t.NextProcessId).HasColumnName("NextProcessId");
            this.Property(t => t.Productivity).HasColumnName("Productivity");
            this.Property(t => t.UnitWeight).HasColumnName("UnitWeight");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.UnitMeasure).HasColumnName("UnitMeasure");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.SectionProcess)
                .WithMany(t => t.ProductionSectionProcesses)
                .HasForeignKey(d => d.ProcessId);
            this.HasRequired(t => t.SectionProcess1)
                .WithMany(t => t.ProductionSectionProcesses1)
                .HasForeignKey(d => d.NextProcessId);

        }
    }
}
