using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MachineErrorMap : EntityTypeConfiguration<MachineError>
    {
        public MachineErrorMap()
        {
            // Primary Key
            this.HasKey(t => t.MachineErrorId);

            // Properties
            this.Property(t => t.MachineErrorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MachineError", "Factory");
            this.Property(t => t.MachineErrorId).HasColumnName("MachineErrorId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
