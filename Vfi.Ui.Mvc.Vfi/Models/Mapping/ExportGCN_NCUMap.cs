using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ExportGCN_NCUMap : EntityTypeConfiguration<ExportGCN_NCU>
    {
        public ExportGCN_NCUMap()
        {
            // Primary Key
            this.HasKey(t => t.ExportId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.TransactionCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ExportGCN_NCU", "Inv");
            this.Property(t => t.ExportId).HasColumnName("ExportId");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.BoxNumber).HasColumnName("BoxNumber");
            this.Property(t => t.BlockNumber).HasColumnName("BlockNumber");
            this.Property(t => t.TransactionCode).HasColumnName("TransactionCode");
            this.Property(t => t.ProviderName).HasColumnName("ProviderName");
            this.Property(t => t.ExportDate).HasColumnName("ExportDate");
            this.Property(t => t.PlatingFormId).HasColumnName("PlatingFormId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.IsWorkOrder).HasColumnName("IsWorkOrder");

            // Relationships
            this.HasOptional(t => t.PlatingForm)
                .WithMany(t => t.ExportGCN_NCU)
                .HasForeignKey(d => d.PlatingFormId);
            this.HasOptional(t => t.Transaction)
                .WithMany(t => t.ExportGCN_NCU)
                .HasForeignKey(d => d.TransactionId);

        }
    }
}
