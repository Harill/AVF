using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MaterialUseInShiftMap : EntityTypeConfiguration<MaterialUseInShift>
    {
        public MaterialUseInShiftMap()
        {
            // Primary Key
            this.HasKey(t => t.UseId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.Shift2)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Shift1)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.UsedCode)
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaterialUseInShift", "Inv");
            this.Property(t => t.UseId).HasColumnName("UseId");
            this.Property(t => t.UsedDate).HasColumnName("UsedDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.Shift2).HasColumnName("Shift2");
            this.Property(t => t.Shift1).HasColumnName("Shift1");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.UsedCode).HasColumnName("UsedCode");
            this.Property(t => t.Type).HasColumnName("Type");
        }
    }
}
