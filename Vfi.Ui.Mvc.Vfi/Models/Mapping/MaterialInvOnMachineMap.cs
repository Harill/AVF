using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MaterialInvOnMachineMap : EntityTypeConfiguration<MaterialInvOnMachine>
    {
        public MaterialInvOnMachineMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaterialInvOnMachine", "Inv");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.MaterialInvId).HasColumnName("MaterialInvId");
            this.Property(t => t.TotalQuantity).HasColumnName("TotalQuantity");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Id).HasColumnName("Id");

            // Relationships
            this.HasOptional(t => t.Machine)
                .WithMany(t => t.MaterialInvOnMachines)
                .HasForeignKey(d => d.MachineId);
            this.HasOptional(t => t.MaterialInventory)
                .WithMany(t => t.MaterialInvOnMachines)
                .HasForeignKey(d => d.MaterialInvId);

        }
    }
}
