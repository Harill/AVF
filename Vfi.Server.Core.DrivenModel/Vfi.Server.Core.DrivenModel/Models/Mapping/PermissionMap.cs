using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class PermissionMap : EntityTypeConfiguration<Permission>
    {
        public PermissionMap()
        {
            // Primary Key
            HasKey(t => t.PermissionId);

            // Properties
            Property(t => t.Description)
                .HasMaxLength(150);

            // Table & Column Mappings
            ToTable("Permission", "System");
            Property(t => t.PermissionId).HasColumnName("PermissionId");
            Property(t => t.Creation).HasColumnName("Creation");
            Property(t => t.Modification).HasColumnName("Modification");
            Property(t => t.Deletion).HasColumnName("Deletion");
            Property(t => t.Execution).HasColumnName("Execution");
            Property(t => t.UserID).HasColumnName("UserID");
            Property(t => t.WorkGroupID).HasColumnName("WorkGroupID");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.FunctionID).HasColumnName("FunctionID");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasOptional(t => t.Function)
                .WithMany(t => t.Permissions)
                .HasForeignKey(d => d.FunctionID);
            HasOptional(t => t.User)
                .WithMany(t => t.Permissions)
                .HasForeignKey(d => d.UserID);
            HasOptional(t => t.WorkGroup)
                .WithMany(t => t.Permissions)
                .HasForeignKey(d => d.WorkGroupID);

        }
    }
}
