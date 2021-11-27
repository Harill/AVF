using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MaterialUseFormDetailMap : EntityTypeConfiguration<MaterialUseFormDetail>
    {
        public MaterialUseFormDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.LotName)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("MaterialUseFormDetail", "Inv");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.MaterialInvId).HasColumnName("MaterialInvId");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.EarlyQuantity).HasColumnName("EarlyQuantity");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.EditQuantity).HasColumnName("EditQuantity");
            this.Property(t => t.PendingQuantity).HasColumnName("PendingQuantity");
            this.Property(t => t.BoxNumber).HasColumnName("BoxNumber");
            this.Property(t => t.LotName).HasColumnName("LotName");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            //this.HasOptional(t => t.Machine)
            //    .WithMany(t => t.MaterialUseFormDetails)
            //    .HasForeignKey(d => d.MachineId);
            //this.HasOptional(t => t.MaterialInventory)
            //    .WithMany(t => t.MaterialUseFormDetails)
            //    .HasForeignKey(d => d.MaterialInvId);
            this.HasOptional(t => t.MaterialUseInShiftForm)
                .WithMany(t => t.MaterialUseFormDetails)
                .HasForeignKey(d => d.FormId);

        }
    }
}
