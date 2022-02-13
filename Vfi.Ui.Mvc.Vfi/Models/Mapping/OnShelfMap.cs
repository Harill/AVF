using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class OnShelfMap : EntityTypeConfiguration<OnShelf>
    {
        public OnShelfMap()
        {
            // Primary Key
            this.HasKey(t => t.OnShelfId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OnShelf", "Inv");
            this.Property(t => t.OnShelfId).HasColumnName("OnShelfId");
            this.Property(t => t.DrawerId).HasColumnName("DrawerId");
            this.Property(t => t.ReferenceId).HasColumnName("ReferenceId");
            this.Property(t => t.ReferenceInvId).HasColumnName("ReferenceInvId");
            this.Property(t => t.OnDate).HasColumnName("OnDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.InventoryDrawer)
                .WithMany(t => t.OnShelves)
                .HasForeignKey(d => d.DrawerId);

        }
    }
}
