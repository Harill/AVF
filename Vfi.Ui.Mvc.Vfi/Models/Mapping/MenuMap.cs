using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MenuMap : EntityTypeConfiguration<Menu>
    {
        public MenuMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuId);

            // Properties
            this.Property(t => t.MenuCode)
                .HasMaxLength(50);

            this.Property(t => t.MenuName)
                .HasMaxLength(50);

            this.Property(t => t.ProjectName)
                .HasMaxLength(50);

            this.Property(t => t.ControllerName)
                .HasMaxLength(50);

            this.Property(t => t.ActionName)
                .HasMaxLength(50);

            this.Property(t => t.Area)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Menu", "System");
            this.Property(t => t.MenuId).HasColumnName("MenuId");
            this.Property(t => t.MenuCode).HasColumnName("MenuCode");
            this.Property(t => t.MenuName).HasColumnName("MenuName");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.MenuLevel).HasColumnName("MenuLevel");
            this.Property(t => t.ProjectName).HasColumnName("ProjectName");
            this.Property(t => t.ControllerName).HasColumnName("ControllerName");
            this.Property(t => t.ActionName).HasColumnName("ActionName");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IDX).HasColumnName("IDX");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.Menu2)
                .WithMany(t => t.Menu1)
                .HasForeignKey(d => d.ParentId);

        }
    }
}
