using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ImportNCU_QCBMap : EntityTypeConfiguration<ImportNCU_QCB>
    {
        public ImportNCU_QCBMap()
        {
            // Primary Key
            this.HasKey(t => t.ImportId);

            // Properties
            this.Property(t => t.TransactionCode)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.ProviderName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ImportNCU_QCB", "Inv");
            this.Property(t => t.ImportId).HasColumnName("ImportId");
            this.Property(t => t.TransactionCode).HasColumnName("TransactionCode");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ImportDate).HasColumnName("ImportDate");
            this.Property(t => t.BoxNumber).HasColumnName("BoxNumber");
            this.Property(t => t.ProviderName).HasColumnName("ProviderName");
            this.Property(t => t.PlatingFormId).HasColumnName("PlatingFormId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.PurchasingSignature).HasColumnName("PurchasingSignature");
            this.Property(t => t.IsWorkOrder).HasColumnName("IsWorkOrder");

            // Relationships
            this.HasOptional(t => t.PlatingForm)
                .WithMany(t => t.ImportNCU_QCB)
                .HasForeignKey(d => d.PlatingFormId);
            this.HasOptional(t => t.Transaction)
                .WithMany(t => t.ImportNCU_QCB)
                .HasForeignKey(d => d.TransactionId);

        }
    }
}
