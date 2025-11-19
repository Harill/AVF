using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductHistoryMap : EntityTypeConfiguration<ProductHistory>
    {
        public ProductHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.HistoryId);

            // Properties
            this.Property(t => t.CodeNumber)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductHistory", "Production");
            this.Property(t => t.HistoryId).HasColumnName("HistoryId");
            this.Property(t => t.HistoryDate).HasColumnName("HistoryDate");
            this.Property(t => t.CodeNumber).HasColumnName("CodeNumber");
            this.Property(t => t.Before).HasColumnName("Before");
            this.Property(t => t.After).HasColumnName("After");
            this.Property(t => t.RefImage).HasColumnName("RefImage");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ProductId).HasColumnName("ProductId");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductHistories)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
