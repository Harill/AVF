using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class TransactionWeighingMap : EntityTypeConfiguration<TransactionWeighing>
    {
        public TransactionWeighingMap()
        {
            // Primary Key
            this.HasKey(t => t.WeighingId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TransactionWeighing", "Inv");
            this.Property(t => t.WeighingId).HasColumnName("WeighingId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.UnitWeight).HasColumnName("UnitWeight");
            this.Property(t => t.PackageWeight).HasColumnName("PackageWeight");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasOptional(t => t.Transaction)
                .WithMany(t => t.TransactionWeighings)
                .HasForeignKey(d => d.TransactionId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.TransactionWeighings)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.TransactionWeighings)
                .HasForeignKey(d => d.WarehouseId);

        }
    }
}
