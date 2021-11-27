using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class TrackingRepairEmployeeMap : EntityTypeConfiguration<TrackingRepairEmployee>
    {
        public TrackingRepairEmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.TrackingId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TrackingRepairEmployee", "Factory");
            this.Property(t => t.TrackingId).HasColumnName("TrackingId");
            this.Property(t => t.RepairEmployeeId).HasColumnName("RepairEmployeeId");
            this.Property(t => t.QcEmployeeId).HasColumnName("QcEmployeeId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.FinishDate).HasColumnName("FinishDate");
            this.Property(t => t.Shift).HasColumnName("Shift");
            this.Property(t => t.FixQuantity).HasColumnName("FixQuantity");
            this.Property(t => t.MoreTime).HasColumnName("MoreTime");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.MachineId).HasColumnName("MachineId");

            // Relationships
            this.HasRequired(t => t.Machine)
                .WithMany(t => t.TrackingRepairEmployees)
                .HasForeignKey(d => d.MachineId);
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.TrackingRepairEmployees)
                .HasForeignKey(d => d.RepairEmployeeId);
            this.HasRequired(t => t.Employee1)
                .WithMany(t => t.TrackingRepairEmployees1)
                .HasForeignKey(d => d.QcEmployeeId);

        }
    }
}
