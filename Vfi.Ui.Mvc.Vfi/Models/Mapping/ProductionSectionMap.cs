using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionSectionMap : EntityTypeConfiguration<ProductionSection>
    {
        public ProductionSectionMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductionSectionId);

            // Properties
            this.Property(t => t.SectionName)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(50);

            this.Property(t => t.InsertUser)
                .HasMaxLength(50);

            this.Property(t => t.UpdateUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionSection", "Factory");
            this.Property(t => t.ProductionSectionId).HasColumnName("ProductionSectionId");
            this.Property(t => t.SectionName).HasColumnName("SectionName");
            this.Property(t => t.SectionCost).HasColumnName("SectionCost");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.InsertDate).HasColumnName("InsertDate");
            this.Property(t => t.InsertUser).HasColumnName("InsertUser");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.UpdateUser).HasColumnName("UpdateUser");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.SectionIndex).HasColumnName("SectionIndex");
            this.Property(t => t.Productivity).HasColumnName("Productivity");
            this.Property(t => t.SectionId).HasColumnName("SectionId");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.IsMainProcess).HasColumnName("IsMainProcess");

            // Relationships
            this.HasOptional(t => t.Machine)
                .WithMany(t => t.ProductionSections)
                .HasForeignKey(d => d.MachineId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductionSections)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.Section)
                .WithMany(t => t.ProductionSections)
                .HasForeignKey(d => d.SectionId);

        }
    }
}
