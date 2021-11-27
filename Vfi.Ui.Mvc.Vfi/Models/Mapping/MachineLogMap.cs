using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MachineLogMap : EntityTypeConfiguration<MachineLog>
    {
        public MachineLogMap()
        {
            // Primary Key
            this.HasKey(t => t.LogId);

            // Properties
            // Table & Column Mappings
            this.ToTable("MachineLog", "Factory");
            this.Property(t => t.LogId).HasColumnName("LogId");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.DateLog).HasColumnName("DateLog");

            // Relationships
            this.HasOptional(t => t.Machine)
                .WithMany(t => t.MachineLogs)
                .HasForeignKey(d => d.MachineId);

        }
    }
}
