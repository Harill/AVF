using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SectionProcessTransactionMap : EntityTypeConfiguration<SectionProcessTransaction>
    {
        public SectionProcessTransactionMap()
        {
            // Primary Key
            this.HasKey(t => t.TransactionId);

            // Properties
            this.Property(t => t.TransactionCode)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SectionProcessTransaction", "Factory");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            this.Property(t => t.TransactionCode).HasColumnName("TransactionCode");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
        }
    }
}
