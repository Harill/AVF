using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SmartProduction2Map : EntityTypeConfiguration<SmartProduction2>
    {
        public SmartProduction2Map()
        {
            // Primary Key
            this.HasKey(t => t.SmartId);

            // Properties
            // Table & Column Mappings
            this.ToTable("SmartProduction2", "Factory");
            this.Property(t => t.SmartId).HasColumnName("SmartId");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.SectionIssueId).HasColumnName("SectionIssueId");
            this.Property(t => t.SectionReceiptId).HasColumnName("SectionReceiptId");
            this.Property(t => t.QuantityKg).HasColumnName("QuantityKg");
            this.Property(t => t.Time).HasColumnName("Time");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Machine)
                .WithMany(t => t.SmartProduction2)
                .HasForeignKey(d => d.MachineId);
            this.HasRequired(t => t.ProductionSection)
                .WithMany(t => t.SmartProduction2)
                .HasForeignKey(d => d.SectionIssueId);
            this.HasOptional(t => t.ProductionSection1)
                .WithMany(t => t.SmartProduction21)
                .HasForeignKey(d => d.SectionReceiptId);
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.SmartProduction2)
                .HasForeignKey(d => d.EmployeeId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.SmartProduction2)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
