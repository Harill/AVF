using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class MachineAppraisalMap : EntityTypeConfiguration<MachineAppraisal>
    {
        public MachineAppraisalMap()
        {
            // Primary Key
            HasKey(t => t.AppraisalId);

            // Properties
            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("MachineAppraisal", "Factory");
            Property(t => t.AppraisalId).HasColumnName("AppraisalId");
            Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            Property(t => t.MachineId).HasColumnName("MachineId");
            Property(t => t.ProductId).HasColumnName("ProductId");
            Property(t => t.AppraisalTime).HasColumnName("AppraisalTime");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasOptional(t => t.Machine)
                .WithMany(t => t.MachineAppraisals)
                .HasForeignKey(d => d.MachineId);
            HasOptional(t => t.Product)
                .WithMany(t => t.MachineAppraisals)
                .HasForeignKey(d => d.ProductId);
            HasOptional(t => t.Warehouse)
                .WithMany(t => t.MachineAppraisals)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
