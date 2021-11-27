using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class CustomerAccessPermissionMap : EntityTypeConfiguration<CustomerAccessPermission>
    {
        public CustomerAccessPermissionMap()
        {
            // Primary Key
            this.HasKey(t => t.RoleId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CustomerAccessPermission", "Sales");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.CustomerAccessPermissions)
                .HasForeignKey(d => d.CustomerId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.CustomerAccessPermissions)
                .HasForeignKey(d => d.UserId);

        }
    }
}
