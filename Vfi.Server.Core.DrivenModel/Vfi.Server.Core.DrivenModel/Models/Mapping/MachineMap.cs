using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class MachineMap : EntityTypeConfiguration<Machine>
    {
        public MachineMap()
        {
            // Primary Key
            HasKey(t => t.MachineId);

            // Properties
            Property(t => t.MachineName)
                .HasMaxLength(150);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Machine", "Factory");
            Property(t => t.MachineId).HasColumnName("MachineId");
            Property(t => t.MachineName).HasColumnName("MachineName");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
