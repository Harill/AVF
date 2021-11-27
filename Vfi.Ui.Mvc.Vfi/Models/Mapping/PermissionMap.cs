using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class PermissionMap : EntityTypeConfiguration<Permission>
    {
        public PermissionMap()
        {
            // Primary Key
            this.HasKey(t => t.PermissionId);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Permission", "System");
            this.Property(t => t.PermissionId).HasColumnName("PermissionId");
            this.Property(t => t.Creation).HasColumnName("Creation");
            this.Property(t => t.Modification).HasColumnName("Modification");
            this.Property(t => t.Deletion).HasColumnName("Deletion");
            this.Property(t => t.Execution).HasColumnName("Execution");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.WorkGroupID).HasColumnName("WorkGroupID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.FunctionID).HasColumnName("FunctionID");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.Function)
                .WithMany(t => t.Permissions)
                .HasForeignKey(d => d.FunctionID);
            this.HasOptional(t => t.User)
                .WithMany(t => t.Permissions)
                .HasForeignKey(d => d.UserID);
            this.HasOptional(t => t.WorkGroup)
                .WithMany(t => t.Permissions)
                .HasForeignKey(d => d.WorkGroupID);

        }
    }
}
