using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class OrderStatusMap : EntityTypeConfiguration<OrderStatus>
    {
        public OrderStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderStatusId);

            // Properties
            // Table & Column Mappings
            this.ToTable("OrderStatuses", "Sales");
            this.Property(t => t.OrderStatusId).HasColumnName("OrderStatusId");
            this.Property(t => t.OrderDetailId).HasColumnName("OrderDetailId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasOptional(t => t.OrderDetail)
                .WithMany(t => t.OrderStatuses)
                .HasForeignKey(d => d.OrderDetailId);

        }
    }
}
