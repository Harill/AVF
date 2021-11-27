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

            // Table & Column Mappings
            this.ToTable("WorkOrder", "Purchasing");
            this.Property(t => t.WorkOrderId).HasColumnName("WorkOrderId");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ScrapReasonId).HasColumnName("ScrapReasonId");
            this.Property(t => t.OrderQty).HasColumnName("OrderQty");
            this.Property(t => t.StockedQty).HasColumnName("StockedQty");
            this.Property(t => t.ScrappedQty).HasColumnName("ScrappedQty");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.DueDate).HasColumnName("DueDate");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.ScrapReason)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.ScrapReasonId);
            this.HasOptional(t => t.Order)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.OrderId);

        }
    }
}
