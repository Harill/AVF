using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class WorkOrderRoutingMap : EntityTypeConfiguration<WorkOrderRouting>
    {
        public WorkOrderRoutingMap()
        {
            // Primary Key
            HasKey(t => t.RoutingId);

            // Properties
            Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("WorkOrderRouting", "Purchasing");
            Property(t => t.RoutingId).HasColumnName("RoutingId");
            Property(t => t.WorkOrderId).HasColumnName("WorkOrderId");
            Property(t => t.ProductId).HasColumnName("ProductId");
            Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            Property(t => t.ScheduledStartDate).HasColumnName("ScheduledStartDate");
            Property(t => t.ScheduledEndDate).HasColumnName("ScheduledEndDate");
            Property(t => t.ActualStartDate).HasColumnName("ActualStartDate");
            Property(t => t.ActualEndDate).HasColumnName("ActualEndDate");
            Property(t => t.ActualResourceHrs).HasColumnName("ActualResourceHrs");
            Property(t => t.PlannedCost).HasColumnName("PlannedCost");
            Property(t => t.ActualCost).HasColumnName("ActualCost");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.WorkOrder)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.WorkOrderId);

        }
    }
}
