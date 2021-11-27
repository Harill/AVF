using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class ToolMap : EntityTypeConfiguration<Tool>
    {
        public ToolMap()
        {
            // Primary Key
            HasKey(t => t.ToolId);

            // Properties
            Property(t => t.ToolName)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Tool", "Factory");
            Property(t => t.ToolId).HasColumnName("ToolId");
            Property(t => t.ToolName).HasColumnName("ToolName");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
