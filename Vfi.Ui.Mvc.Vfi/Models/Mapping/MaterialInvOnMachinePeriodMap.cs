using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MaterialInvOnMachinePeriodMap : EntityTypeConfiguration<MaterialInvOnMachinePeriod>
    {
        public MaterialInvOnMachinePeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodId);

            // Properties
            this.Property(t => t.Note)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaterialInvOnMachinePeriod", "Inv");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.MaterialInvId).HasColumnName("MaterialInvId");
            this.Property(t => t.EarlyQuantity).HasColumnName("EarlyQuantity");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.LastQuantity).HasColumnName("LastQuantity");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.PeriodId).HasColumnName("PeriodId");
            this.Property(t => t.PeriodDate).HasColumnName("PeriodDate");

            // Relationships
            this.HasOptional(t => t.Machine)
                .WithMany(t => t.MaterialInvOnMachinePeriods)
                .HasForeignKey(d => d.MachineId);
            this.HasOptional(t => t.MaterialInventory)
                .WithMany(t => t.MaterialInvOnMachinePeriods)
                .HasForeignKey(d => d.MaterialInvId);

        }
    }
}
