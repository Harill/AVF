using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            HasKey(t => t.UserId);

            // Properties
            Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Password)
                .HasMaxLength(255);

            Property(t => t.FullName)
                .HasMaxLength(500);

            Property(t => t.Email)
                .HasMaxLength(150);

            // Table & Column Mappings
            ToTable("User", "System");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.Username).HasColumnName("Username");
            Property(t => t.Password).HasColumnName("Password");
            Property(t => t.FullName).HasColumnName("FullName");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
