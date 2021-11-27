using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            HasKey(t => t.ProductId);

            // Properties
            Property(t => t.ProductCode)
                .HasMaxLength(50);

            Property(t => t.ProductName)
                .HasMaxLength(255);

            Property(t => t.DesignNo)
                .HasMaxLength(50);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Product", "Production");
            Property(t => t.ProductId).HasColumnName("ProductId");
            Property(t => t.CustomerId).HasColumnName("CustomerId");
            Property(t => t.MaterialId).HasColumnName("MaterialId");
            Property(t => t.ProductCode).HasColumnName("ProductCode");
            Property(t => t.ProductName).HasColumnName("ProductName");
            Property(t => t.DesignNo).HasColumnName("DesignNo");
            Property(t => t.Diameter).HasColumnName("Diameter");
            Property(t => t.Length).HasColumnName("Length");
            Property(t => t.Weight).HasColumnName("Weight");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            Property(t => t.ForecastsQuality).HasColumnName("ForecastsQuality");

            // Relationships
            HasRequired(t => t.Material)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.MaterialId);
            HasRequired(t => t.Customer)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.CustomerId);

        }
    }
}
