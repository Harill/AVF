using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class TransactionFptMap : EntityTypeConfiguration<TransactionFpt>
    {
        public TransactionFptMap()
        {
            // Primary Key
            this.HasKey(t => t.TransactionId);

            // Properties
            this.Property(t => t.TransactionCode)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TransactionFpt", "Purchasing");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.TransactionCode).HasColumnName("TransactionCode");
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.EoI).HasColumnName("EoI");
            this.Property(t => t.Fpt).HasColumnName("Fpt");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.PoId).HasColumnName("PoId");
            this.Property(t => t.InventorySignature).HasColumnName("InventorySignature");
            this.Property(t => t.QcSignature).HasColumnName("QcSignature");
            this.Property(t => t.PurchasingSignature).HasColumnName("PurchasingSignature");
            this.Property(t => t.AccountantSignature).HasColumnName("AccountantSignature");
            this.Property(t => t.ExchangeRate).HasColumnName("ExchangeRate");
            this.Property(t => t.IsInternal).HasColumnName("IsInternal");


            // Relationships
            this.HasOptional(t => t.PurchaseOrder)
                .WithMany(t => t.TransactionFpts)
                .HasForeignKey(d => d.PoId);

        }
    }
}
