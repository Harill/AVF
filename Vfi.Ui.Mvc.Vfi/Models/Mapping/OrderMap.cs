using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderId);

            // Properties
            this.Property(t => t.OrderNumber)
                .HasMaxLength(50);

            this.Property(t => t.PoNumber)
                .HasMaxLength(50);

            this.Property(t => t.LotNumber)
                .HasMaxLength(50);

            this.Property(t => t.ModelNumber)
                .HasMaxLength(50);

            this.Property(t => t.BillToAddress)
                .HasMaxLength(4000);

            this.Property(t => t.ShipToAddress)
                .HasMaxLength(4000);

            this.Property(t => t.CurrencyCode)
                .HasMaxLength(3);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Orders", "Sales");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.ParentOrderId).HasColumnName("ParentOrderId");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.SalesPersonId).HasColumnName("SalesPersonId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.DueDate).HasColumnName("DueDate");
            this.Property(t => t.ShippedDate).HasColumnName("ShippedDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.OrderNumber).HasColumnName("OrderNumber");
            this.Property(t => t.PoNumber).HasColumnName("PoNumber");
            this.Property(t => t.LotNumber).HasColumnName("LotNumber");
            this.Property(t => t.ModelNumber).HasColumnName("ModelNumber");
            this.Property(t => t.BillToAddress).HasColumnName("BillToAddress");
            this.Property(t => t.ShipToAddress).HasColumnName("ShipToAddress");
            this.Property(t => t.ShipMethodId).HasColumnName("ShipMethodId");
            this.Property(t => t.ShipmentDay).HasColumnName("ShipmentDay");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.PaymentTermId).HasColumnName("PaymentTermId");

            // Relationships
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.CustomerId);
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.SalesPersonId);
            this.HasOptional(t => t.Order1)
                .WithMany(t => t.Orders1)
                .HasForeignKey(d => d.ParentOrderId);

        }
    }
}
