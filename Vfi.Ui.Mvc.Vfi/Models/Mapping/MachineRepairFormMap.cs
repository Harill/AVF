using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MachineRepairFormMap : EntityTypeConfiguration<MachineRepairForm>
    {
        public MachineRepairFormMap()
        {
            // Primary Key
            this.HasKey(t => t.FormId);

            // Properties
            this.Property(t => t.CreateUser)
                .HasMaxLength(50);

            this.Property(t => t.StartUser)
                .HasMaxLength(50);

            this.Property(t => t.FinishUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MachineRepairForm", "Factory");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.StateId).HasColumnName("StateId");
            this.Property(t => t.ErrorCause).HasColumnName("ErrorCause");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
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
            this.Property(t => t.SectionId).HasColumnName("SectionId");
            this.Property(t => t.CauseDate).HasColumnName("CauseDate");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.ErrorQuantity).HasColumnName("ErrorQuantity");
            this.Property(t => t.ErrorCauseId).HasColumnName("ErrorCauseId");

            // Relationships
            this.HasOptional(t => t.ErrorCauseForm)
                .WithMany(t => t.MachineRepairForms)
                .HasForeignKey(d => d.ErrorCauseId);
            this.HasRequired(t => t.Machine)
                .WithMany(t => t.MachineRepairForms)
                .HasForeignKey(d => d.MachineId);
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.MachineRepairForms)
                .HasForeignKey(d => d.EmployeeId);
            this.HasOptional(t => t.Employee1)
                .WithMany(t => t.MachineRepairForms1)
                .HasForeignKey(d => d.CreateUserId);
            this.HasRequired(t => t.MachineState)
                .WithMany(t => t.MachineRepairForms)
                .HasForeignKey(d => d.StateId);
            this.HasOptional(t => t.MachineStateDetail)
                .WithMany(t => t.MachineRepairForms)
                .HasForeignKey(d => d.FixId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.MachineRepairForms)
                .HasForeignKey(d => d.ProductId);
            this.HasOptional(t => t.ProductionSection)
                .WithMany(t => t.MachineRepairForms)
                .HasForeignKey(d => d.SectionId);

        }
    }
}
