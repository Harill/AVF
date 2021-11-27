using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ContextLogMap : EntityTypeConfiguration<ContextLog>
    {
        public ContextLogMap()
        {
            // Primary Key
            this.HasKey(t => t.LogId);

            // Properties
            this.Property(t => t.ControllerName)
                .HasMaxLength(50);

            this.Property(t => t.ActionName)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.LogText)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ContextLog", "System");
            this.Property(t => t.LogId).HasColumnName("LogId");
            this.Property(t => t.ControllerName).HasColumnName("ControllerName");
            this.Property(t => t.ActionName).HasColumnName("ActionName");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.LogText).HasColumnName("LogText");
        }
    }
}
