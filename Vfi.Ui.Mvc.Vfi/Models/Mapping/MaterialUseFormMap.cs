using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MaterialUseFormMap : EntityTypeConfiguration<MaterialUseForm>
    {
        public MaterialUseFormMap()
        {
            // Primary Key
            this.HasKey(t => t.UseId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.ShiftName)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("MaterialUseForm", "Inv");
            this.Property(t => t.UseId).HasColumnName("UseId");
            this.Property(t => t.UseDate).HasColumnName("UseDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ShiftType).HasColumnName("ShiftType");
            this.Property(t => t.ShiftName).HasColumnName("ShiftName");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
