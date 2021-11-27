using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class DefectTransactionDetailMap : EntityTypeConfiguration<DefectTransactionDetail>
    {
        public DefectTransactionDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.DefectExpand)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DefectTransactionDetail", "Factory");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.QuantityDefect).HasColumnName("QuantityDefect");
            this.Property(t => t.Destroy).HasColumnName("Destroy");
            this.Property(t => t.Recheck).HasColumnName("Recheck");
            this.Property(t => t.Reprocess).HasColumnName("Reprocess");
            this.Property(t => t.DefectId).HasColumnName("DefectId");
            this.Property(t => t.NextWarehouseProcessId).HasColumnName("NextWarehouseProcessId");
            this.Property(t => t.RemedyId).HasColumnName("RemedyId");
            this.Property(t => t.Shift).HasColumnName("Shift");
            this.Property(t => t.DefectExpand).HasColumnName("DefectExpand");
            this.Property(t => t.ReferenceDetailId).HasColumnName("ReferenceDetailId");
            this.Property(t => t.StoreCode).HasColumnName("StoreCode");

            // Relationships
            this.HasRequired(t => t.DefectTransaction)
                .WithMany(t => t.DefectTransactionDetails)
                .HasForeignKey(d => d.TransactionId);
            this.HasOptional(t => t.Machine)
                .WithMany(t => t.DefectTransactionDetails)
                .HasForeignKey(d => d.MachineId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.DefectTransactionDetails)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.ProductionDefect)
                .WithMany(t => t.DefectTransactionDetails)
                .HasForeignKey(d => d.DefectId);
            this.HasOptional(t => t.ProductionDefectRemedy)
                .WithMany(t => t.DefectTransactionDetails)
                .HasForeignKey(d => d.RemedyId);
            this.HasOptional(t => t.Warehouse)
                .WithMany(t => t.DefectTransactionDetails)
                .HasForeignKey(d => d.NextWarehouseProcessId);

        }
    }
}
