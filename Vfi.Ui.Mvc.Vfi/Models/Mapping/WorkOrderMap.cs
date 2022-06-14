using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class WorkOrderMap : EntityTypeConfiguration<WorkOrder>
    {
        public WorkOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkOrderId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SerialNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WorkOrder", "Factory");
            this.Property(t => t.WorkOrderId).HasColumnName("WorkOrderId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.OrderQty).HasColumnName("OrderQty");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.DueDate).HasColumnName("DueDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.OrderDetailId).HasColumnName("OrderDetailId");
            this.Property(t => t.PlannedTime).HasColumnName("PlannedTime");
            this.Property(t => t.RunTime).HasColumnName("RunTime");

            // Relationships
            this.HasRequired(t => t.OrderDetail)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.OrderDetailId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
