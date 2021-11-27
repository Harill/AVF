using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ToolUseDetailMap : EntityTypeConfiguration<ToolUseDetail>
    {
        public ToolUseDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ToolUseDetail", "Inv");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.UseId).HasColumnName("UseId");
            this.Property(t => t.ToolInvMachineId).HasColumnName("ToolInvMachineId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.ToolInvOnMachine)
                .WithMany(t => t.ToolUseDetails)
                .HasForeignKey(d => d.ToolInvMachineId);
            this.HasRequired(t => t.ToolUse)
                .WithMany(t => t.ToolUseDetails)
                .HasForeignKey(d => d.UseId);

        }
    }
}
