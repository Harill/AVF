using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class TransactionDetailMap : EntityTypeConfiguration<TransactionDetail>
    {
        public TransactionDetailMap()
        {
            // Primary Key
            HasKey(t => t.TransactionDetailId);

            // Properties
            Property(t => t.UnitMeasure)
                .HasMaxLength(3);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("TransactionDetail", "Inv");
            Property(t => t.TransactionDetailId).HasColumnName("TransactionDetailId");
            Property(t => t.TransactionId).HasColumnName("TransactionId");
            Property(t => t.ReferenceId).HasColumnName("ReferenceId");
            Property(t => t.MoP).HasColumnName("MoP");
            Property(t => t.Quantity).HasColumnName("Quantity");
            Property(t => t.QuantityKg).HasColumnName("QuantityKg");
            Property(t => t.Price).HasColumnName("Price");
            Property(t => t.UnitMeasure).HasColumnName("UnitMeasure");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasOptional(t => t.Transaction)
                .WithMany(t => t.TransactionDetails)
                .HasForeignKey(d => d.TransactionId);
            HasOptional(t => t.Material)
                .WithMany(t => t.TransactionDetails)
                .HasForeignKey(d => d.ReferenceId);
            HasOptional(t => t.Product)
                .WithMany(t => t.TransactionDetails)
                .HasForeignKey(d => d.ReferenceId);

        }
    }
}
