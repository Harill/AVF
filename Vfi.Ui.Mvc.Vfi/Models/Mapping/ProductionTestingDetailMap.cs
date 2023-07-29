using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionTestingDetailMap : EntityTypeConfiguration<ProductionTestingDetail>
    {
        public ProductionTestingDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.TestingCode)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionTestingDetail", "Factory");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ProductionTestingId).HasColumnName("ProductionTestingId");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.TestingCode).HasColumnName("TestingCode");
            this.Property(t => t.TestingName).HasColumnName("TestingName");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.MinNumber).HasColumnName("MinNumber");
            this.Property(t => t.MaxNumber).HasColumnName("MaxNumber");
            this.Property(t => t.TestRate).HasColumnName("TestRate");

            // Relationships
            this.HasRequired(t => t.ProductionTesting)
                .WithMany(t => t.ProductionTestingDetails)
                .HasForeignKey(d => d.ProductionTestingId);

        }
    }
}
