using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class UserWorkGroupMap : EntityTypeConfiguration<UserWorkGroup>
    {
        public UserWorkGroupMap()
        {
            // Primary Key
            HasKey(t => new { t.UserId, t.WorkGoupId });

            // Properties
            Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.WorkGoupId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("UserWorkGroup", "System");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.WorkGoupId).HasColumnName("WorkGoupId");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.User)
                .WithMany(t => t.UserWorkGroups)
                .HasForeignKey(d => d.UserId);
            HasRequired(t => t.WorkGroup)
                .WithMany(t => t.UserWorkGroups)
                .HasForeignKey(d => d.WorkGoupId);

        }
    }
}
