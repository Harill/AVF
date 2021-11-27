using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class Production2TransactionMap : EntityTypeConfiguration<Production2Transaction>
    {
        public Production2TransactionMap()
        {
            // Primary Key
            this.HasKey(t => t.TransactionId);

            // Properties
            this.Property(t => t.TransactionCode)
                .HasMaxLength(50);

            this.Property(t => t.EoI)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Production2Transaction", "Factory");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.TransactionCode).HasColumnName("TransactionCode");
            this.Property(t => t.EoI).HasColumnName("EoI");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
        }
    }
}
