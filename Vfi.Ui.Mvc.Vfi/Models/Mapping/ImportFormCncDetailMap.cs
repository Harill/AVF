using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ImportFormCncDetailMap : EntityTypeConfiguration<ImportFormCncDetail>
    {
        public ImportFormCncDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ImportFormCncDetail", "Inv");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ImportId).HasColumnName("ImportId");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductWeight).HasColumnName("ProductWeight");
            this.Property(t => t.Number1).HasColumnName("Number1");
            this.Property(t => t.Processing1).HasColumnName("Processing1");
            this.Property(t => t.DefectProduct1).HasColumnName("DefectProduct1");
            this.Property(t => t.Number2).HasColumnName("Number2");
            this.Property(t => t.Processing2).HasColumnName("Processing2");
            this.Property(t => t.DefectProduct2).HasColumnName("DefectProduct2");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.Productivity).HasColumnName("Productivity");
            this.Property(t => t.ProductInvId).HasColumnName("ProductInvId");

            // Relationships
            this.HasRequired(t => t.Machine)
                .WithMany(t => t.ImportFormCncDetails)
                .HasForeignKey(d => d.MachineId);
            this.HasRequired(t => t.ImportFormCnc)
                .WithMany(t => t.ImportFormCncDetails)
                .HasForeignKey(d => d.ImportId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ImportFormCncDetails)
                .HasForeignKey(d => d.ProductId);
            this.HasOptional(t => t.ProductInventory)
                .WithMany(t => t.ImportFormCncDetails)
                .HasForeignKey(d => d.ProductInvId);

        }
    }
}
