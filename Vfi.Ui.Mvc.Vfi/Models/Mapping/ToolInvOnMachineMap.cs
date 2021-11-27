using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ToolInvOnMachineMap : EntityTypeConfiguration<ToolInvOnMachine>
    {
        public ToolInvOnMachineMap()
        {
            // Primary Key
            this.HasKey(t => t.ToolInvMachineId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ToolInvOnMachine", "Inv");
            this.Property(t => t.ToolInvMachineId).HasColumnName("ToolInvMachineId");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.ToolInvId).HasColumnName("ToolInvId");
            this.Property(t => t.TotalQuantity).HasColumnName("TotalQuantity");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.Machine)
                .WithMany(t => t.ToolInvOnMachines)
                .HasForeignKey(d => d.MachineId);

        }
    }
}
