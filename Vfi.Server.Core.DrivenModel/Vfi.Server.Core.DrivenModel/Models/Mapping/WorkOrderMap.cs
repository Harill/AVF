using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class WorkOrderMap : EntityTypeConfiguration<WorkOrder>
    {
        public WorkOrderMap()
        {
            // Primary Key
            HasKey(t => t.WorkOrderId);

            // Properties
            Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("WorkOrder", "Purchasing");
            Property(t => t.WorkOrderId).HasColumnName("WorkOrderId");
            Property(t => t.SalesOrderId).HasColumnName("SalesOrderId");
            Property(t => t.ProductId).HasColumnName("ProductId");
            Property(t => t.ScrapReasonId).HasColumnName("ScrapReasonId");
            Property(t => t.OrderQty).HasColumnName("OrderQty");
            Property(t => t.StockedQty).HasColumnName("StockedQty");
            Property(t => t.ScrappedQty).HasColumnName("ScrappedQty");
            Property(t => t.StartDate).HasColumnName("StartDate");
            Property(t => t.EndDate).HasColumnName("EndDate");
            Property(t => t.DueDate).HasColumnName("DueDate");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasOptional(t => t.ScrapReason)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.ScrapReasonId);
            HasOptional(t => t.SalesOrder)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.SalesOrderId);

        }
    }
}
