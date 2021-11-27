using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class WorkOrderRoutingMap : EntityTypeConfiguration<WorkOrderRouting>
    {
        public WorkOrderRoutingMap()
        {
            // Primary Key
            this.HasKey(t => t.RoutingId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WorkOrderRouting", "Purchasing");
            this.Property(t => t.RoutingId).HasColumnName("RoutingId");
            this.Property(t => t.WorkOrderId).HasColumnName("WorkOrderId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.ScheduledStartDate).HasColumnName("ScheduledStartDate");
            this.Property(t => t.ScheduledEndDate).HasColumnName("ScheduledEndDate");
            this.Property(t => t.ActualStartDate).HasColumnName("ActualStartDate");
            this.Property(t => t.ActualEndDate).HasColumnName("ActualEndDate");
            this.Property(t => t.ActualResourceHrs).HasColumnName("ActualResourceHrs");
            this.Property(t => t.PlannedCost).HasColumnName("PlannedCost");
            this.Property(t => t.ActualCost).HasColumnName("ActualCost");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.WorkOrder)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.WorkOrderId);

        }
    }
}
