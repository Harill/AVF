using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ExportGCN_NCUDetailMap : EntityTypeConfiguration<ExportGCN_NCUDetail>
    {
        public ExportGCN_NCUDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.Note)
                .HasMaxLength(50);

            this.Property(t => t.Package)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ExportGCN_NCUDetail", "Inv");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ExportId).HasColumnName("ExportId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.RequestNumber).HasColumnName("RequestNumber");
            this.Property(t => t.RealNumber).HasColumnName("RealNumber");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.PlatingDetailId).HasColumnName("PlatingDetailId");
            this.Property(t => t.Package).HasColumnName("Package");
            this.Property(t => t.ProductInvId).HasColumnName("ProductInvId");
            this.Property(t => t.TransactionDetailId).HasColumnName("TransactionDetailId");

            // Relationships
            this.HasRequired(t => t.ExportGCN_NCU)
                .WithMany(t => t.ExportGCN_NCUDetail)
                .HasForeignKey(d => d.ExportId);
            this.HasOptional(t => t.PlatingFormDetail)
                .WithMany(t => t.ExportGCN_NCUDetail)
                .HasForeignKey(d => d.PlatingDetailId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ExportGCN_NCUDetail)
                .HasForeignKey(d => d.ProductId);
            this.HasOptional(t => t.ProductInventory)
                .WithMany(t => t.ExportGCN_NCUDetail)
                .HasForeignKey(d => d.ProductInvId);
            this.HasOptional(t => t.TransactionDetail)
                .WithMany(t => t.ExportGCN_NCUDetail)
                .HasForeignKey(d => d.TransactionDetailId);

        }
    }
}
