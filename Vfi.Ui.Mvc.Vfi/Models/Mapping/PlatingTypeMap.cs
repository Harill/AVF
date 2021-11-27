using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class PlatingTypeMap : EntityTypeConfiguration<PlatingType>
    {
        public PlatingTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.PlatingId);

            // Properties
            this.Property(t => t.PlatingName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired();

            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PlatingType", "Purchasing");
            this.Property(t => t.PlatingId).HasColumnName("PlatingId");
            this.Property(t => t.PlatingName).HasColumnName("PlatingName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
        }
    }
}
