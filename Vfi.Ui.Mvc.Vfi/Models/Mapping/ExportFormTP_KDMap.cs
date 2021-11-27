using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ExportFormTP_KDMap : EntityTypeConfiguration<ExportFormTP_KD>
    {
        public ExportFormTP_KDMap()
        {
            // Primary Key
            this.HasKey(t => t.ExportId);

            // Properties
            this.Property(t => t.CarNumber)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.TransactionCode)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ExportFormTP_KD", "Inv");
            this.Property(t => t.ExportId).HasColumnName("ExportId");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.Transporter).HasColumnName("Transporter");
            this.Property(t => t.CompanyTransporter).HasColumnName("CompanyTransporter");
            this.Property(t => t.CarNumber).HasColumnName("CarNumber");
            this.Property(t => t.DateTransporter).HasColumnName("DateTransporter");
            this.Property(t => t.DateCreate).HasColumnName("DateCreate");
            this.Property(t => t.TransactionCode).HasColumnName("TransactionCode");
            this.Property(t => t.TotalBox).HasColumnName("TotalBox");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.CreatedInvoice).HasColumnName("CreatedInvoice");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasOptional(t => t.Customer)
                .WithMany(t => t.ExportFormTP_KD)
                .HasForeignKey(d => d.CustomerId);
            this.HasOptional(t => t.Order)
                .WithMany(t => t.ExportFormTP_KD)
                .HasForeignKey(d => d.OrderId);

        }
    }
}
