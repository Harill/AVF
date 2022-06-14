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

            this.Property(t => t.RoutingName)
                .HasMaxLength(50);

            this.Property(t => t.RoutingLot)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WorkOrderRouting", "Factory");
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
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.MaterialInvId).HasColumnName("MaterialInvId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.MoreInfo).HasColumnName("MoreInfo");
            this.Property(t => t.RoutingName).HasColumnName("RoutingName");
            this.Property(t => t.RoutingIndex).HasColumnName("RoutingIndex");
            this.Property(t => t.NextRouteId).HasColumnName("NextRouteId");
            this.Property(t => t.RoutingLot).HasColumnName("RoutingLot");

            // Relationships
            this.HasOptional(t => t.Machine)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.MachineId);
            this.HasRequired(t => t.WorkOrder)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.WorkOrderId);
            this.HasOptional(t => t.MaterialInventory)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.MaterialInvId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.ProductId);
            this.HasOptional(t => t.Warehouse)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.WarehouseId);
            this.HasOptional(t => t.WorkOrderRouting2)
                .WithMany(t => t.WorkOrderRouting1)
                .HasForeignKey(d => d.NextRouteId);

        }
    }
}
