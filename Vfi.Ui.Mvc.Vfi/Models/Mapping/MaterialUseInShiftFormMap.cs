using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MaterialUseInShiftFormMap : EntityTypeConfiguration<MaterialUseInShiftForm>
    {
        public MaterialUseInShiftFormMap()
        {
            // Primary Key
            this.HasKey(t => t.FormId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.ShiftName)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FormCode)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("MaterialUseInShiftForm", "Inv");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ShiftType).HasColumnName("ShiftType");
            this.Property(t => t.ShiftName).HasColumnName("ShiftName");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.FormCode).HasColumnName("FormCode");
            this.Property(t => t.Type).HasColumnName("Type");
        }
    }
}
