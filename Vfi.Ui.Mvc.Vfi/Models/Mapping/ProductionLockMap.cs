using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionLockMap : EntityTypeConfiguration<ProductionLock>
    {
        public ProductionLockMap()
        {
            // Primary Key
            this.HasKey(t => t.LockId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.Shift1Name)
                .HasMaxLength(50);

            this.Property(t => t.Shift2Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionLock", "Factory");
            this.Property(t => t.LockId).HasColumnName("LockId");
            this.Property(t => t.LockDate).HasColumnName("LockDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Production1Lock).HasColumnName("Production1Lock");
            this.Property(t => t.Production2Lock).HasColumnName("Production2Lock");
            this.Property(t => t.CNCLock).HasColumnName("CNCLock");
            this.Property(t => t.Shift1Name).HasColumnName("Shift1Name");
            this.Property(t => t.Shift2Name).HasColumnName("Shift2Name");
        }
    }
}
