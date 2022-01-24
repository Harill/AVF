using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionTestingMachineMap : EntityTypeConfiguration<ProductionTestingMachine>
    {
        public ProductionTestingMachineMap()
        {
            // Primary Key
            this.HasKey(t => t.TestingToolId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionTestingMachine", "Factory");
            this.Property(t => t.TestingToolId).HasColumnName("TestingToolId");
            this.Property(t => t.TestingDetailId).HasColumnName("TestingDetailId");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.MachineTypeId).HasColumnName("MachineTypeId");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasRequired(t => t.ProcessingType)
                .WithMany(t => t.ProductionTestingMachines)
                .HasForeignKey(d => d.MachineTypeId);
            this.HasRequired(t => t.ProductionTestingDetail)
                .WithMany(t => t.ProductionTestingMachines)
                .HasForeignKey(d => d.TestingDetailId);

        }
    }
}
