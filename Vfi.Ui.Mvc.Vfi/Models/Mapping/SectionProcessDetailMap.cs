using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SectionProcessDetailMap : EntityTypeConfiguration<SectionProcessDetail>
    {
        public SectionProcessDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("SectionProcessDetail", "Factory");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.SectionId).HasColumnName("SectionId");
            this.Property(t => t.ProcessId).HasColumnName("ProcessId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.DetailIndex).HasColumnName("DetailIndex");

            // Relationships
            this.HasRequired(t => t.Section)
                .WithMany(t => t.SectionProcessDetails)
                .HasForeignKey(d => d.SectionId);
            this.HasRequired(t => t.SectionProcess)
                .WithMany(t => t.SectionProcessDetails)
                .HasForeignKey(d => d.ProcessId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.SectionProcessDetails)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
