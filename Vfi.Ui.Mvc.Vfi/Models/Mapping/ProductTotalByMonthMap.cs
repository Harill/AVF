using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductTotalByMonthMap : EntityTypeConfiguration<ProductTotalByMonth>
    {
        public ProductTotalByMonthMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProductTotalByMonth", "Inv");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Month).HasColumnName("Month");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.KhoSX2_CNC).HasColumnName("KhoSX2_CNC");
            this.Property(t => t.KhoSX2_SX2).HasColumnName("KhoSX2_SX2");
            this.Property(t => t.KhoNhietLuyen).HasColumnName("KhoNhietLuyen");
            this.Property(t => t.KhoChoRungBong).HasColumnName("KhoChoRungBong");
            this.Property(t => t.KhoChoGCN).HasColumnName("KhoChoGCN");
            this.Property(t => t.KhoNhaCungUng).HasColumnName("KhoNhaCungUng");
            this.Property(t => t.KhoQC_A).HasColumnName("KhoQC_A");
            this.Property(t => t.KhoQC_B).HasColumnName("KhoQC_B");
            this.Property(t => t.ChoXuLy).HasColumnName("ChoXuLy");
            this.Property(t => t.PhePham).HasColumnName("PhePham");
            this.Property(t => t.ThanhPham_A).HasColumnName("ThanhPham_A");
            this.Property(t => t.ThanhPham_B).HasColumnName("ThanhPham_B");
            this.Property(t => t.LuyKeSanXuat).HasColumnName("LuyKeSanXuat");
            this.Property(t => t.LuyKeXuat).HasColumnName("LuyKeXuat");
            this.Property(t => t.DonHangConLai).HasColumnName("DonHangConLai");

            // Relationships
            this.HasOptional(t => t.Product)
                .WithMany(t => t.ProductTotalByMonths)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
