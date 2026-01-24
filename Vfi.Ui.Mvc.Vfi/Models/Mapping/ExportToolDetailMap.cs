using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ExportToolDetailMap : EntityTypeConfiguration<ExportToolDetail>
    {
        public ExportToolDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ExportDetailId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ExportToolDetail", "Inv");
            this.Property(t => t.ExportDetailId).HasColumnName("ExportDetailId");
            this.Property(t => t.ExportId).HasColumnName("ExportId");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.ToolInvId).HasColumnName("ToolInvId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.TransactionDetailId).HasColumnName("TransactionDetailId");
            this.Property(t => t.RealToolId).HasColumnName("RealToolId");                             // 19/01/2026


            // Relationships
            this.HasOptional(t => t.Machine)
                .WithMany(t => t.ExportToolDetails)
                .HasForeignKey(d => d.MachineId);
            this.HasRequired(t => t.ExportTool)
                .WithMany(t => t.ExportToolDetails)
                .HasForeignKey(d => d.ExportId);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.ExportToolDetails)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.ToolInventory)
                .WithMany(t => t.ExportToolDetails)
                .HasForeignKey(d => d.ToolInvId);
            this.HasOptional(t => t.TransactionFptDetail)
                .WithMany(t => t.ExportToolDetails)
                .HasForeignKey(d => d.TransactionDetailId);

        }
    }
}
