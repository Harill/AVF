using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MachineMap : EntityTypeConfiguration<Machine>
    {
        public MachineMap()
        {
            // Primary Key
            this.HasKey(t => t.MachineId);

            // Properties
            this.Property(t => t.MachineName)
                .HasMaxLength(150);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Machine", "Factory");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.MachineName).HasColumnName("MachineName");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.StateId).HasColumnName("StateId");
            this.Property(t => t.ProductActive).HasColumnName("ProductActive");
            this.Property(t => t.Number).HasColumnName("Number");
            this.Property(t => t.DayRate).HasColumnName("DayRate");
            this.Property(t => t.StartProductionDate).HasColumnName("StartProductionDate");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.DiagramType).HasColumnName("DiagramType");
            this.Property(t => t.ColumnIndex).HasColumnName("ColumnIndex");
            this.Property(t => t.RowIndex).HasColumnName("RowIndex");
            this.Property(t => t.ErrorCause).HasColumnName("ErrorCause");
            this.Property(t => t.HowToFix).HasColumnName("HowToFix");
            this.Property(t => t.ModifiedState).HasColumnName("ModifiedState");
            this.Property(t => t.ModifiedFix).HasColumnName("ModifiedFix");
            this.Property(t => t.ProcessingTypeId).HasColumnName("ProcessingTypeId");
            this.Property(t => t.Production2).HasColumnName("Production2");
            this.Property(t => t.MachineFunction).HasColumnName("MachineFunction");

            // Relationships
            this.HasOptional(t => t.MachineState)
                .WithMany(t => t.Machines)
                .HasForeignKey(d => d.StateId);
            this.HasOptional(t => t.ProcessingType)
                .WithMany(t => t.Machines)
                .HasForeignKey(d => d.ProcessingTypeId);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.Machines)
                .HasForeignKey(d => d.ProductActive);

        }
    }
}
