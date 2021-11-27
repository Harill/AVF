using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SectionProcessTransactionDetailMap : EntityTypeConfiguration<SectionProcessTransactionDetail>
    {
        public SectionProcessTransactionDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            // Table & Column Mappings
            this.ToTable("SectionProcessTransactionDetail", "Factory");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.FromProcessId).HasColumnName("FromProcessId");
            this.Property(t => t.ToProcessId).HasColumnName("ToProcessId");
            this.Property(t => t.ProcessQuantity).HasColumnName("ProcessQuantity");
            this.Property(t => t.DefectQuantity).HasColumnName("DefectQuantity");
            this.Property(t => t.UnitWeight).HasColumnName("UnitWeight");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.Time).HasColumnName("Time");
            this.Property(t => t.Overtime).HasColumnName("Overtime");

            // Relationships
            this.HasRequired(t => t.SectionProcess)
                .WithMany(t => t.SectionProcessTransactionDetails)
                .HasForeignKey(d => d.FromProcessId);
            this.HasRequired(t => t.SectionProcess1)
                .WithMany(t => t.SectionProcessTransactionDetails1)
                .HasForeignKey(d => d.ToProcessId);
            this.HasRequired(t => t.SectionProcessTransaction)
                .WithMany(t => t.SectionProcessTransactionDetails)
                .HasForeignKey(d => d.TransactionId);

        }
    }
}
