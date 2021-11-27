using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionDefectTypeMap : EntityTypeConfiguration<ProductionDefectType>
    {
        public ProductionDefectTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.DefectTypeId);

            // Properties
            this.Property(t => t.DefectTypeName)
                .HasMaxLength(50);

            this.Property(t => t.DefectTypeCode)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionDefectType", "Factory");
            this.Property(t => t.DefectTypeId).HasColumnName("DefectTypeId");
            this.Property(t => t.DefectTypeName).HasColumnName("DefectTypeName");
            this.Property(t => t.DefectTypeCode).HasColumnName("DefectTypeCode");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
