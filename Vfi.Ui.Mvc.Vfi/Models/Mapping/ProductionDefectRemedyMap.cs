using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionDefectRemedyMap : EntityTypeConfiguration<ProductionDefectRemedy>
    {
        public ProductionDefectRemedyMap()
        {
            // Primary Key
            this.HasKey(t => t.RemedyId);

            // Properties
            this.Property(t => t.RemedyCode)
                .HasMaxLength(50);

            this.Property(t => t.RemedyName)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionDefectRemedy", "Factory");
            this.Property(t => t.RemedyId).HasColumnName("RemedyId");
            this.Property(t => t.RemedyCode).HasColumnName("RemedyCode");
            this.Property(t => t.RemedyName).HasColumnName("RemedyName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ProcessWarehouseId).HasColumnName("ProcessWarehouseId");

            // Relationships
            this.HasOptional(t => t.Warehouse)
                .WithMany(t => t.ProductionDefectRemedies)
                .HasForeignKey(d => d.ProcessWarehouseId);

        }
    }
}
