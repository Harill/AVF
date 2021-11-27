using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class SalesOrderMap : EntityTypeConfiguration<SalesOrder>
    {
        public SalesOrderMap()
        {
            // Primary Key
            HasKey(t => t.SalesOrderId);

            // Properties
            Property(t => t.SalesOrderNumber)
                .HasMaxLength(50);

            Property(t => t.PurchaseOrderNumber)
                .HasMaxLength(50);

            Property(t => t.BillToAddress)
                .IsRequired()
                .HasMaxLength(4000);

            Property(t => t.ShipToAddress)
                .IsRequired()
                .HasMaxLength(4000);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("SalesOrder", "Sales");
            Property(t => t.SalesOrderId).HasColumnName("SalesOrderId");
            Property(t => t.CustomerId).HasColumnName("CustomerId");
            Property(t => t.SalesPersonId).HasColumnName("SalesPersonId");
            Property(t => t.OrderDate).HasColumnName("OrderDate");
            Property(t => t.DueDate).HasColumnName("DueDate");
            Property(t => t.ShipDate).HasColumnName("ShipDate");
            Property(t => t.Status).HasColumnName("Status");
            Property(t => t.SalesOrderNumber).HasColumnName("SalesOrderNumber");
            Property(t => t.PurchaseOrderNumber).HasColumnName("PurchaseOrderNumber");
            Property(t => t.BillToAddress).HasColumnName("BillToAddress");
            Property(t => t.ShipToAddress).HasColumnName("ShipToAddress");
            Property(t => t.ShipMethodId).HasColumnName("ShipMethodId");
            Property(t => t.Note).HasColumnName("Note");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Customer)
                .WithMany(t => t.SalesOrders)
                .HasForeignKey(d => d.CustomerId);
            HasOptional(t => t.Employee)
                .WithMany(t => t.SalesOrders)
                .HasForeignKey(d => d.SalesPersonId);

        }
    }
}
