using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MachineStateMap : EntityTypeConfiguration<MachineState>
    {
        public MachineStateMap()
        {
            // Primary Key
            this.HasKey(t => t.StateId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.WarrningColor)
                .HasMaxLength(50);

            this.Property(t => t.StateCode)
                .HasMaxLength(50);

            this.Property(t => t.NameEN)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MachineState", "Factory");
            this.Property(t => t.StateId).HasColumnName("StateId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.WarrningPoint).HasColumnName("WarrningPoint");
            this.Property(t => t.WarrningColor).HasColumnName("WarrningColor");
            this.Property(t => t.Timing).HasColumnName("Timing");
            this.Property(t => t.StateCode).HasColumnName("StateCode");
            this.Property(t => t.EstimateTime).HasColumnName("EstimateTime");
            this.Property(t => t.IsSetProduct).HasColumnName("IsSetProduct");
            this.Property(t => t.NameEN).HasColumnName("NameEN");
        }
    }
}
