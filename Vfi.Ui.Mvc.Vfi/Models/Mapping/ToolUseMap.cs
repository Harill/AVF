using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ToolUseMap : EntityTypeConfiguration<ToolUse>
    {
        public ToolUseMap()
        {
            // Primary Key
            this.HasKey(t => t.UseId);

            // Properties
            this.Property(t => t.UsedCode)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.Department)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ToolUse", "Inv");
            this.Property(t => t.UseId).HasColumnName("UseId");
            this.Property(t => t.UsedDate).HasColumnName("UsedDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.UsedCode).HasColumnName("UsedCode");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Department).HasColumnName("Department");
        }
    }
}
