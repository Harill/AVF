using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class ToolDetailMap : EntityTypeConfiguration<ToolDetail>
    {
        public ToolDetailMap()
        {
            // Primary Key
            HasKey(t => t.ToolDetailId);

            // Properties
            Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ToolDetail", "Factory");
            Property(t => t.ToolDetailId).HasColumnName("ToolDetailId");
            Property(t => t.ToolOrderId).HasColumnName("ToolOrderId");
            Property(t => t.ToolId).HasColumnName("ToolId");
            Property(t => t.Quantity).HasColumnName("Quantity");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Tool)
                .WithMany(t => t.ToolDetails)
                .HasForeignKey(d => d.ToolId);
            HasRequired(t => t.ToolOrder)
                .WithMany(t => t.ToolDetails)
                .HasForeignKey(d => d.ToolOrderId);

        }
    }
}
