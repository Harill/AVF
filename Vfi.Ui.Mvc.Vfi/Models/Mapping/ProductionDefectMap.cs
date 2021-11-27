using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionDefectMap : EntityTypeConfiguration<ProductionDefect>
    {
        public ProductionDefectMap()
        {
            // Primary Key
            this.HasKey(t => t.DefectId);

            // Properties
            this.Property(t => t.DefectName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired();

            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DefectCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionDefect", "Factory");
            this.Property(t => t.DefectId).HasColumnName("DefectId");
            this.Property(t => t.DefectName).HasColumnName("DefectName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.DefectTypeId).HasColumnName("DefectTypeId");
            this.Property(t => t.DefectCode).HasColumnName("DefectCode");
            this.Property(t => t.DefaultRemedyId).HasColumnName("DefaultRemedyId");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductionDefects)
                .HasForeignKey(d => d.ProductId);
            this.HasOptional(t => t.ProductionDefectRemedy)
                .WithMany(t => t.ProductionDefects)
                .HasForeignKey(d => d.DefaultRemedyId);
            this.HasRequired(t => t.ProductionDefectType)
                .WithMany(t => t.ProductionDefects)
                .HasForeignKey(d => d.DefectTypeId);

        }
    }
}
