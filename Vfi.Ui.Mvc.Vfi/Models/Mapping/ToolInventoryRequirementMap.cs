using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ToolInventoryRequirementMap : EntityTypeConfiguration<ToolInventoryRequirement>
    {
        public ToolInventoryRequirementMap()
        {
            // Primary Key
            this.HasKey(t => t.RequirementId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ToolInventoryRequirement", "Factory");
            this.Property(t => t.RequirementId).HasColumnName("RequirementId");
            this.Property(t => t.ToolId).HasColumnName("ToolId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.RequireQuantity).HasColumnName("RequireQuantity");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasRequired(t => t.Tool)
                .WithMany(t => t.ToolInventoryRequirements)
                .HasForeignKey(d => d.ToolId);

        }
    }
}
