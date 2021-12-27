using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class RealTestingMap : EntityTypeConfiguration<RealTesting>
    {
        public RealTestingMap()
        {
            // Primary Key
            this.HasKey(t => t.RealTestId);

            // Properties
            this.Property(t => t.TestCode)
                .HasMaxLength(50);

            this.Property(t => t.TestName)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RealTesting", "Factory");
            this.Property(t => t.RealTestId).HasColumnName("RealTestId");
            this.Property(t => t.ReferenceTestingDetailId).HasColumnName("ReferenceTestingDetailId");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.ProductionMachineId).HasColumnName("ProductionMachineId");
            this.Property(t => t.ProductionDate).HasColumnName("ProductionDate");
            this.Property(t => t.TestDate).HasColumnName("TestDate");
            this.Property(t => t.TestEmployeeId).HasColumnName("TestEmployeeId");
            this.Property(t => t.MachineTypeId).HasColumnName("MachineTypeId");
            this.Property(t => t.TestCode).HasColumnName("TestCode");
            this.Property(t => t.TestName).HasColumnName("TestName");
            this.Property(t => t.TestNumber).HasColumnName("TestNumber");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.FromWarehouseId).HasColumnName("FromWarehouseId");

            // Relationships
            this.HasRequired(t => t.Machine)
                .WithMany(t => t.RealTestings)
                .HasForeignKey(d => d.ProductionMachineId);
            this.HasOptional(t => t.ProcessingType)
                .WithMany(t => t.RealTestings)
                .HasForeignKey(d => d.MachineTypeId);
            this.HasRequired(t => t.ProductionTestingDetail)
                .WithMany(t => t.RealTestings)
                .HasForeignKey(d => d.ReferenceTestingDetailId);
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.RealTestings)
                .HasForeignKey(d => d.TestEmployeeId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.RealTestings)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.RealTestings)
                .HasForeignKey(d => d.WarehouseId);
            this.HasRequired(t => t.Warehouse1)
                .WithMany(t => t.RealTestings1)
                .HasForeignKey(d => d.FromWarehouseId);

        }
    }
}
