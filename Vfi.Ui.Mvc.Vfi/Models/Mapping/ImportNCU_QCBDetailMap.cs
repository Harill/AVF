using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ImportNCU_QCBDetailMap : EntityTypeConfiguration<ImportNCU_QCBDetail>
    {
        public ImportNCU_QCBDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.Package)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ImportNCU_QCBDetail", "Inv");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ImportId).HasColumnName("ImportId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.RequestNumber).HasColumnName("RequestNumber");
            this.Property(t => t.RealNumber).HasColumnName("RealNumber");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.ExportDetailId).HasColumnName("ExportDetailId");
            this.Property(t => t.Package).HasColumnName("Package");
            this.Property(t => t.ProductInvId).HasColumnName("ProductInvId");
            this.Property(t => t.TransactionDetailId).HasColumnName("TransactionDetailId");

            // Relationships
            this.HasOptional(t => t.ExportGCN_NCUDetail)
                .WithMany(t => t.ImportNCU_QCBDetail)
                .HasForeignKey(d => d.ExportDetailId);
            this.HasRequired(t => t.ImportNCU_QCB)
                .WithMany(t => t.ImportNCU_QCBDetail)
                .HasForeignKey(d => d.ImportId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ImportNCU_QCBDetail)
                .HasForeignKey(d => d.ProductId);
            this.HasOptional(t => t.ProductInventory)
                .WithMany(t => t.ImportNCU_QCBDetail)
                .HasForeignKey(d => d.ProductInvId);
            this.HasOptional(t => t.TransactionDetail)
                .WithMany(t => t.ImportNCU_QCBDetail)
                .HasForeignKey(d => d.TransactionDetailId);

        }
    }
}
