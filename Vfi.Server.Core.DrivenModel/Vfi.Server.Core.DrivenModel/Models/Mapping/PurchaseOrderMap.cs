using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class PurchaseOrderMap : EntityTypeConfiguration<PurchaseOrder>
    {
        public PurchaseOrderMap()
        {
            // Primary Key
            HasKey(t => t.PurchaseOrderId);

            // Properties
            Property(t => t.RevisionNumber)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("PurchaseOrder", "Purchasing");
            Property(t => t.PurchaseOrderId).HasColumnName("PurchaseOrderId");
            Property(t => t.VendorId).HasColumnName("VendorId");
            Property(t => t.ShipMethodId).HasColumnName("ShipMethodId");
            Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            Property(t => t.RevisionNumber).HasColumnName("RevisionNumber");
            Property(t => t.Status).HasColumnName("Status");
            Property(t => t.OrderDate).HasColumnName("OrderDate");
            Property(t => t.ShipDate).HasColumnName("ShipDate");
            Property(t => t.SubTotal).HasColumnName("SubTotal");
            Property(t => t.TaxAmt).HasColumnName("TaxAmt");
            Property(t => t.Freight).HasColumnName("Freight");
            Property(t => t.TotalDue).HasColumnName("TotalDue");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Employee)
                .WithMany(t => t.PurchaseOrders)
                .HasForeignKey(d => d.EmployeeId);
            HasRequired(t => t.ShipMethod)
                .WithMany(t => t.PurchaseOrders)
                .HasForeignKey(d => d.ShipMethodId);
            HasRequired(t => t.Vendor)
                .WithMany(t => t.PurchaseOrders)
                .HasForeignKey(d => d.VendorId);

        }
    }
}
