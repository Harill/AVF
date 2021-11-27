using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class UserWorkGroupMap : EntityTypeConfiguration<UserWorkGroup>
    {
        public UserWorkGroupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserId, t.WorkGoupId });

            // Properties
            this.Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WorkGoupId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UserWorkGroup", "System");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.WorkGoupId).HasColumnName("WorkGoupId");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserWorkGroups)
                .HasForeignKey(d => d.UserId);
            this.HasRequired(t => t.WorkGroup)
                .WithMany(t => t.UserWorkGroups)
                .HasForeignKey(d => d.WorkGoupId);

        }
    }
}
