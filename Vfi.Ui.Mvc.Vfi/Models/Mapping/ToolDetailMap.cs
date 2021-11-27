using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ToolDetailMap : EntityTypeConfiguration<ToolDetail>
    {
        public ToolDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ToolDetailId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ToolDetail", "Factory");
            this.Property(t => t.ToolDetailId).HasColumnName("ToolDetailId");
            this.Property(t => t.ToolOrderId).HasColumnName("ToolOrderId");
            this.Property(t => t.ToolId).HasColumnName("ToolId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Tool)
                .WithMany(t => t.ToolDetails)
                .HasForeignKey(d => d.ToolId);
            this.HasRequired(t => t.ToolOrder)
                .WithMany(t => t.ToolDetails)
                .HasForeignKey(d => d.ToolOrderId);

        }
    }
}
