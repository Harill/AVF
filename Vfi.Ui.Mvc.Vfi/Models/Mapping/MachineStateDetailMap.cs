using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MachineStateDetailMap : EntityTypeConfiguration<MachineStateDetail>
    {
        public MachineStateDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.StateCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MachineStateDetail", "Factory");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.StateId).HasColumnName("StateId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Timing).HasColumnName("Timing");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.StateCode).HasColumnName("StateCode");
        }
    }
}
