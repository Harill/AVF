using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ExportFormQC_TPMap : EntityTypeConfiguration<ExportFormQC_TP>
    {
        public ExportFormQC_TPMap()
        {
            // Primary Key
            this.HasKey(t => t.ExportId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.TransactionCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ExportFormQC_TP", "Inv");
            this.Property(t => t.ExportId).HasColumnName("ExportId");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.TransactionCode).HasColumnName("TransactionCode");
        }
    }
}
