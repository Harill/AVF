using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ToolMap : EntityTypeConfiguration<Tool>
    {
        public ToolMap()
        {
            // Primary Key
            this.HasKey(t => t.ToolId);

            // Properties
            this.Property(t => t.ToolName)
                .HasMaxLength(255);

            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ToolCode)
                .HasMaxLength(255);

            this.Property(t => t.ToolFullCode)
                .HasMaxLength(255);

            this.Property(t => t.ToolDesignNo)
                .HasMaxLength(50);

            this.Property(t => t.ToolMaterial)
                .HasMaxLength(50);

            this.Property(t => t.ToolProduction)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Tool", "Factory");
            this.Property(t => t.ToolId).HasColumnName("ToolId");
            this.Property(t => t.ToolName).HasColumnName("ToolName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ToolCode).HasColumnName("ToolCode");
            this.Property(t => t.ToolFullCode).HasColumnName("ToolFullCode");
            this.Property(t => t.ToolDesignNo).HasColumnName("ToolDesignNo");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.ToolMaterial).HasColumnName("ToolMaterial");
            this.Property(t => t.MaterialTypeId).HasColumnName("MaterialTypeId");
            this.Property(t => t.ToolTypeId).HasColumnName("ToolTypeId");
            this.Property(t => t.Img).HasColumnName("Img");
            this.Property(t => t.ToolProduction).HasColumnName("ToolProduction");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            // Relationships
            this.HasRequired(t => t.MaterialType)
                .WithMany(t => t.Tools)
                .HasForeignKey(d => d.MaterialTypeId);

        }
    }
}
