using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ImportFormSX1DetailMap : EntityTypeConfiguration<ImportFormSX1Detail>
    {
        public ImportFormSX1DetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.Shift1)
                .HasMaxLength(50);

            this.Property(t => t.Shift2)
                .HasMaxLength(50);

            this.Property(t => t.Machine)
                .HasMaxLength(50);

            this.Property(t => t.UnitMeasure)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ImportFormSX1Detail", "Inv");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ImportId).HasColumnName("ImportId");
            this.Property(t => t.Shift1).HasColumnName("Shift1");
            this.Property(t => t.Number1).HasColumnName("Number1");
            this.Property(t => t.DefectProduct1).HasColumnName("DefectProduct1");
            this.Property(t => t.Shift2).HasColumnName("Shift2");
            this.Property(t => t.Number2).HasColumnName("Number2");
            this.Property(t => t.DefectProduct2).HasColumnName("DefectProduct2");
            this.Property(t => t.Machine).HasColumnName("Machine");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.MaterialInvId).HasColumnName("MaterialInvId");
            this.Property(t => t.MaterialUse1).HasColumnName("MaterialUse1");
            this.Property(t => t.MaterialUse2).HasColumnName("MaterialUse2");
            this.Property(t => t.ProductionRate).HasColumnName("ProductionRate");
            this.Property(t => t.Processing1).HasColumnName("Processing1");
            this.Property(t => t.Processing2).HasColumnName("Processing2");
            this.Property(t => t.ProductWeight).HasColumnName("ProductWeight");
            this.Property(t => t.UseDetailId).HasColumnName("UseDetailId");
            this.Property(t => t.LotNumber).HasColumnName("LotNumber");
            this.Property(t => t.WarehouseExportId).HasColumnName("WarehouseExportId");
            this.Property(t => t.ProcessByMachineId).HasColumnName("ProcessByMachineId");
            this.Property(t => t.UnitMeasure).HasColumnName("UnitMeasure");

            // Relationships
            this.HasOptional(t => t.Machine1)
                .WithMany(t => t.ImportFormSX1Detail)
                .HasForeignKey(d => d.MachineId);
            this.HasRequired(t => t.ImportFormSX1)
                .WithMany(t => t.ImportFormSX1Detail)
                .HasForeignKey(d => d.ImportId);
            this.HasOptional(t => t.MaterialInventory)
                .WithMany(t => t.ImportFormSX1Detail)
                .HasForeignKey(d => d.MaterialInvId);
            this.HasOptional(t => t.MaterialUseDetail)
                .WithMany(t => t.ImportFormSX1Detail)
                .HasForeignKey(d => d.UseDetailId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ImportFormSX1Detail)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
