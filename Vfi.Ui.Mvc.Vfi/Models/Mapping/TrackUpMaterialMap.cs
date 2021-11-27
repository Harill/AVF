using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class TrackUpMaterialMap : EntityTypeConfiguration<TrackUpMaterial>
    {
        public TrackUpMaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TrackUpMaterial", "Factory");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.TrackId).HasColumnName("TrackId");
            this.Property(t => t.MaterialInvId).HasColumnName("MaterialInvId");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.TrackUpMachine)
                .WithMany(t => t.TrackUpMaterials)
                .HasForeignKey(d => d.TrackId);
            this.HasRequired(t => t.MaterialInventory)
                .WithMany(t => t.TrackUpMaterials)
                .HasForeignKey(d => d.MaterialInvId);

        }
    }
}
