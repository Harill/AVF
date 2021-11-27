using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ExportFormTP_KDDetailMap : EntityTypeConfiguration<ExportFormTP_KDDetail>
    {
        public ExportFormTP_KDDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ExportFormTP_KDDetail", "Inv");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ExportId).HasColumnName("ExportId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Quality).HasColumnName("Quality");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.BigBox).HasColumnName("BigBox");
            this.Property(t => t.SmallBox).HasColumnName("SmallBox");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.OrderDetailId).HasColumnName("OrderDetailId");
            this.Property(t => t.TransactionDetailId).HasColumnName("TransactionDetailId");
            this.Property(t => t.IsInvoiced).HasColumnName("IsInvoiced");
            this.Property(t => t.ProductInvId).HasColumnName("ProductInvId");

            // Relationships
            this.HasOptional(t => t.ExportFormTP_KD)
                .WithMany(t => t.ExportFormTP_KDDetail)
                .HasForeignKey(d => d.ExportId);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.ExportFormTP_KDDetail)
                .HasForeignKey(d => d.ProductId);
            this.HasOptional(t => t.OrderDetail)
                .WithMany(t => t.ExportFormTP_KDDetail)
                .HasForeignKey(d => d.OrderDetailId);
            this.HasOptional(t => t.TransactionDetail)
                .WithMany(t => t.ExportFormTP_KDDetail)
                .HasForeignKey(d => d.TransactionDetailId);

        }
    }
}
