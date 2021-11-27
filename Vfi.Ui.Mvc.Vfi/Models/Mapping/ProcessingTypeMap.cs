using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProcessingTypeMap : EntityTypeConfiguration<ProcessingType>
    {
        public ProcessingTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.TypeId);

            // Properties
            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProcessingType", "Factory");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ProcessingFactor).HasColumnName("ProcessingFactor");
            this.Property(t => t.ProcessingSaleFactor).HasColumnName("ProcessingSaleFactor");
            this.Property(t => t.ForWarehouseId).HasColumnName("ForWarehouseId");

            // Relationships
            this.HasOptional(t => t.Warehouse)
                .WithMany(t => t.ProcessingTypes)
                .HasForeignKey(d => d.ForWarehouseId);

        }
    }
}
