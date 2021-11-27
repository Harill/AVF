using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class MenuMap : EntityTypeConfiguration<Menu>
    {
        public MenuMap()
        {
            // Primary Key
            HasKey(t => t.MenuId);

            // Properties
            Property(t => t.MenuCode)
                .HasMaxLength(50);

            Property(t => t.MenuName)
                .HasMaxLength(50);

            Property(t => t.ProjectName)
                .HasMaxLength(50);

            Property(t => t.ControllerName)
                .HasMaxLength(50);

            Property(t => t.ActionName)
                .HasMaxLength(50);

            Property(t => t.Area)
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasMaxLength(150);

            // Table & Column Mappings
            ToTable("Menu", "System");
            Property(t => t.MenuId).HasColumnName("MenuId");
            Property(t => t.MenuCode).HasColumnName("MenuCode");
            Property(t => t.MenuName).HasColumnName("MenuName");
            Property(t => t.ParentId).HasColumnName("ParentId");
            Property(t => t.MenuLevel).HasColumnName("MenuLevel");
            Property(t => t.ProjectName).HasColumnName("ProjectName");
            Property(t => t.ControllerName).HasColumnName("ControllerName");
            Property(t => t.ActionName).HasColumnName("ActionName");
            Property(t => t.Area).HasColumnName("Area");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.IDX).HasColumnName("IDX");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasOptional(t => t.Menu2)
                .WithMany(t => t.Menu1)
                .HasForeignKey(d => d.ParentId);

        }
    }
}
