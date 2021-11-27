using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class DefectTransactionMap : EntityTypeConfiguration<DefectTransaction>
    {
        public DefectTransactionMap()
        {
            // Primary Key
            this.HasKey(t => t.TransactionId);

            // Properties
            this.Property(t => t.TransactionCode)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DefectTransaction", "Factory");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.TransactionCode).HasColumnName("TransactionCode");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ImportTransactionId).HasColumnName("ImportTransactionId");
            this.Property(t => t.EoI).HasColumnName("EoI");
        }
    }
}
