using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class WeighingMachineMap : EntityTypeConfiguration<WeighingMachine>
    {
        public WeighingMachineMap()
        {
            // Primary Key
            this.HasKey(t => t.MachineId);

            // Properties
            this.Property(t => t.MachineCode)
                .HasMaxLength(50);

            this.Property(t => t.MachineName)
                .HasMaxLength(50);

            this.Property(t => t.Port)
                .HasMaxLength(50);

            this.Property(t => t.BaudRate)
                .HasMaxLength(50);

            this.Property(t => t.DataBits)
                .HasMaxLength(50);

            this.Property(t => t.Parity)
                .HasMaxLength(50);

            this.Property(t => t.StopBit)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WeighingMachine", "Production");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.MachineCode).HasColumnName("MachineCode");
            this.Property(t => t.MachineName).HasColumnName("MachineName");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.Port).HasColumnName("Port");
            this.Property(t => t.BaudRate).HasColumnName("BaudRate");
            this.Property(t => t.DataBits).HasColumnName("DataBits");
            this.Property(t => t.Parity).HasColumnName("Parity");
            this.Property(t => t.StopBit).HasColumnName("StopBit");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.WeighingMachines)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
