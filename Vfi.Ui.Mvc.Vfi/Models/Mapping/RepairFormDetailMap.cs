using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class RepairFormDetailMap : EntityTypeConfiguration<RepairFormDetail>
    {
        public RepairFormDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.StartUser)
                .HasMaxLength(50);

            this.Property(t => t.FinishUser)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RepairFormDetail", "Factory");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.StartUser).HasColumnName("StartUser");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.FinishDate).HasColumnName("FinishDate");
            this.Property(t => t.FinishUser).HasColumnName("FinishUser");
            this.Property(t => t.FixId).HasColumnName("FixId");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Shift).HasColumnName("Shift");
            this.Property(t => t.MoreTime).HasColumnName("MoreTime");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.FixQuantity).HasColumnName("FixQuantity");

            // Relationships
            this.HasRequired(t => t.MachineRepairForm)
                .WithMany(t => t.RepairFormDetails)
                .HasForeignKey(d => d.FormId);
            this.HasOptional(t => t.MachineStateDetail)
                .WithMany(t => t.RepairFormDetails)
                .HasForeignKey(d => d.FixId);
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.RepairFormDetails)
                .HasForeignKey(d => d.EmployeeId);

        }
    }
}
