using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ExportMaterialDetailMap : EntityTypeConfiguration<ExportMaterialDetail>
    {
        public ExportMaterialDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ExportDetailId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ExportMaterialDetail", "Inv");
            this.Property(t => t.ExportDetailId).HasColumnName("ExportDetailId");
            this.Property(t => t.ExportId).HasColumnName("ExportId");
            this.Property(t => t.MaterialId).HasColumnName("MaterialId");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.QuantityKg).HasColumnName("QuantityKg");
            this.Property(t => t.MaterialInvId).HasColumnName("MaterialInvId");
            this.Property(t => t.TransactionDetailId).HasColumnName("TransactionDetailId");

            // Relationships
            this.HasOptional(t => t.Machine)
                .WithMany(t => t.ExportMaterialDetails)
                .HasForeignKey(d => d.MachineId);
            this.HasRequired(t => t.ExportMaterial)
                .WithMany(t => t.ExportMaterialDetails)
                .HasForeignKey(d => d.ExportId);
            this.HasRequired(t => t.Material)
                .WithMany(t => t.ExportMaterialDetails)
                .HasForeignKey(d => d.MaterialId);
            this.HasRequired(t => t.MaterialInventory)
                .WithMany(t => t.ExportMaterialDetails)
                .HasForeignKey(d => d.MaterialInvId);
            this.HasOptional(t => t.TransactionDetail)
                .WithMany(t => t.ExportMaterialDetails)
                .HasForeignKey(d => d.TransactionDetailId);

        }
    }
}
