using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class OrderDetailMap : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderDetailId);

            // Properties
            this.Property(t => t.CarrierTrackingNumber)
                .HasMaxLength(25);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.LotNumber)
                .HasMaxLength(50);

            this.Property(t => t.ModelNumber)
                .HasMaxLength(50);

            this.Property(t => t.PONumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrderDetails", "Sales");
            this.Property(t => t.OrderDetailId).HasColumnName("OrderDetailId");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.CarrierTrackingNumber).HasColumnName("CarrierTrackingNumber");
            this.Property(t => t.OrderQty).HasColumnName("OrderQty");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.UnitPriceDiscount).HasColumnName("UnitPriceDiscount");
            this.Property(t => t.LineTotal).HasColumnName("LineTotal");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.VFIDueDate).HasColumnName("VFIDueDate");
            this.Property(t => t.CustomerDueDate).HasColumnName("CustomerDueDate");
            this.Property(t => t.LotNumber).HasColumnName("LotNumber");
            this.Property(t => t.ModelNumber).HasColumnName("ModelNumber");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.PONumber).HasColumnName("PONumber");
            this.Property(t => t.IsComplete).HasColumnName("IsComplete");
            this.Property(t => t.RequiedNumber).HasColumnName("RequiedNumber");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.IsAlert).HasColumnName("IsAlert");
            this.Property(t => t.OrderNote).HasColumnName("OrderNote");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(d => d.ProductId);
            this.HasOptional(t => t.Status1)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(d => d.Status);
            this.HasRequired(t => t.Order)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(d => d.OrderId);

        }
    }
}
