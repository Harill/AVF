using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MaterialUseDetailMap : EntityTypeConfiguration<MaterialUseDetail>
    {
        public MaterialUseDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.Lot)
                .IsFixedLength()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("MaterialUseDetail", "Inv");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.UseId).HasColumnName("UseId");
            this.Property(t => t.MaterialInvId).HasColumnName("MaterialInvId");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.Quantity2).HasColumnName("Quantity2");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.EditQuantity).HasColumnName("EditQuantity");
            this.Property(t => t.BoxNumber).HasColumnName("BoxNumber");
            this.Property(t => t.Lot).HasColumnName("Lot");
            this.Property(t => t.EditQuantity2).HasColumnName("EditQuantity2");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.IsDetroy).HasColumnName("IsDetroy");
            this.Property(t => t.ToMachineId).HasColumnName("ToMachineId");

            // Relationships
            this.HasRequired(t => t.Machine)
                .WithMany(t => t.MaterialUseDetails)
                .HasForeignKey(d => d.MachineId);
            this.HasOptional(t => t.Machine1)
                .WithMany(t => t.MaterialUseDetails1)
                .HasForeignKey(d => d.ToMachineId);
            this.HasRequired(t => t.MaterialInventory)
                .WithMany(t => t.MaterialUseDetails)
                .HasForeignKey(d => d.MaterialInvId);
            this.HasRequired(t => t.MaterialUseInShift)
                .WithMany(t => t.MaterialUseDetails)
                .HasForeignKey(d => d.UseId);

        }
    }
}
