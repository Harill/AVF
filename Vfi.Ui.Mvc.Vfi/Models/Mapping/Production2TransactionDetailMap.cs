using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class Production2TransactionDetailMap : EntityTypeConfiguration<Production2TransactionDetail>
    {
        public Production2TransactionDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.UnitMeasure)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Production2TransactionDetail", "Factory");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.QuantityKg).HasColumnName("QuantityKg");
            this.Property(t => t.UnitMeasure).HasColumnName("UnitMeasure");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.SectionIssueId).HasColumnName("SectionIssueId");
            this.Property(t => t.SectionReceiptId).HasColumnName("SectionReceiptId");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.QuantityDefect).HasColumnName("QuantityDefect");
            this.Property(t => t.Time).HasColumnName("Time");
            this.Property(t => t.OverTime).HasColumnName("OverTime");
            this.Property(t => t.SectionIndex).HasColumnName("SectionIndex");
            this.Property(t => t.QuantityLost).HasColumnName("QuantityLost");

            // Relationships
            this.HasOptional(t => t.Machine)
                .WithMany(t => t.Production2TransactionDetail)
                .HasForeignKey(d => d.MachineId);
            this.HasRequired(t => t.Production2Transaction)
                .WithMany(t => t.Production2TransactionDetail)
                .HasForeignKey(d => d.TransactionId);
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.Production2TransactionDetail)
                .HasForeignKey(d => d.EmployeeId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.Production2TransactionDetail)
                .HasForeignKey(d => d.ProductId);
            this.HasOptional(t => t.ProductionSection)
                .WithMany(t => t.Production2TransactionDetail)
                .HasForeignKey(d => d.SectionIssueId);
            this.HasOptional(t => t.ProductionSection1)
                .WithMany(t => t.Production2TransactionDetail1)
                .HasForeignKey(d => d.SectionReceiptId);

        }
    }
}
