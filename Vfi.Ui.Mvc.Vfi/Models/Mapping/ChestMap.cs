using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ChestMap : EntityTypeConfiguration<Chest>
    {
        public ChestMap()
        {
            // Primary Key
            this.HasKey(t => t.ChestId);

            // Properties
            this.Property(t => t.ChestName)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Chest", "Inv");
            this.Property(t => t.ChestId).HasColumnName("ChestId");
            this.Property(t => t.ChestName).HasColumnName("ChestName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ToolActive).HasColumnName("ToolActive");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
        }
    }
}
