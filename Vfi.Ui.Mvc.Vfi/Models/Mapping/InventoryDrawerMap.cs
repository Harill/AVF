using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class InventoryDrawerMap : EntityTypeConfiguration<InventoryDrawer>
    {
        public InventoryDrawerMap()
        {
            // Primary Key
            this.HasKey(t => t.DrawerId);

            // Properties
            this.Property(t => t.ColumnName)
                .HasMaxLength(50);

            this.Property(t => t.RowName)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.AdditionName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InventoryDrawer", "Inv");
            this.Property(t => t.DrawerId).HasColumnName("DrawerId");
            this.Property(t => t.ShelfId).HasColumnName("ShelfId");
            this.Property(t => t.ColumnName).HasColumnName("ColumnName");
            this.Property(t => t.RowName).HasColumnName("RowName");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ReferenceId).HasColumnName("ReferenceId");
            this.Property(t => t.ReferenceInvId).HasColumnName("ReferenceInvId");
            this.Property(t => t.AdditionName).HasColumnName("AdditionName");

            // Relationships
            this.HasRequired(t => t.InventoryShelf)
                .WithMany(t => t.InventoryDrawers)
                .HasForeignKey(d => d.ShelfId);

        }
    }
}
