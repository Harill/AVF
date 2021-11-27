using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MachineAppraisalMap : EntityTypeConfiguration<MachineAppraisal>
    {
        public MachineAppraisalMap()
        {
            // Primary Key
            this.HasKey(t => t.AppraisalId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MachineAppraisal", "Factory");
            this.Property(t => t.AppraisalId).HasColumnName("AppraisalId");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.AppraisalTime).HasColumnName("AppraisalTime");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.Machine)
                .WithMany(t => t.MachineAppraisals)
                .HasForeignKey(d => d.MachineId);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.MachineAppraisals)
                .HasForeignKey(d => d.ProductId);
            this.HasOptional(t => t.Warehouse)
                .WithMany(t => t.MachineAppraisals)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
