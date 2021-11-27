using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ImportPurchaseOrderMap : EntityTypeConfiguration<ImportPurchaseOrder>
    {
        public ImportPurchaseOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.ImportId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ImportPurchaseOrder", "Purchasing");
            this.Property(t => t.ImportId).HasColumnName("ImportId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.ImportDate).HasColumnName("ImportDate");
            this.Property(t => t.PurchaseOrderId).HasColumnName("PurchaseOrderId");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ExchangeRate).HasColumnName("ExchangeRate");
            this.Property(t => t.PurchasingSignature).HasColumnName("PurchasingSignature");

            // Relationships
            this.HasRequired(t => t.Transaction)
                .WithMany(t => t.ImportPurchaseOrders)
                .HasForeignKey(d => d.TransactionId);
            this.HasOptional(t => t.PurchaseOrder)
                .WithMany(t => t.ImportPurchaseOrders)
                .HasForeignKey(d => d.PurchaseOrderId);

        }
    }
}
