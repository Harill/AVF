using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class PurchaseOrderDetailMap : EntityTypeConfiguration<PurchaseOrderDetail>
    {
        public PurchaseOrderDetailMap()
        {
            // Primary Key
            HasKey(t => t.PurchaseOrderDetailId);

            // Properties
            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("PurchaseOrderDetail", "Purchasing");
            Property(t => t.PurchaseOrderDetailId).HasColumnName("PurchaseOrderDetailId");
            Property(t => t.PurchaseOrderId).HasColumnName("PurchaseOrderId");
            Property(t => t.MaterialClassifiedId).HasColumnName("MaterialClassifiedId");
            Property(t => t.MaterialTypeId).HasColumnName("MaterialTypeId");
            Property(t => t.MaterialId).HasColumnName("MaterialId");
            Property(t => t.OrderQty).HasColumnName("OrderQty");
            Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            Property(t => t.LineTotal).HasColumnName("LineTotal");
            Property(t => t.ReceivedQty).HasColumnName("ReceivedQty");
            Property(t => t.RejectedQty).HasColumnName("RejectedQty");
            Property(t => t.StockedQty).HasColumnName("StockedQty");
            Property(t => t.DueDate).HasColumnName("DueDate");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Material)
                .WithMany(t => t.PurchaseOrderDetails)
                .HasForeignKey(d => d.MaterialId);
            HasRequired(t => t.MaterialClassified)
                .WithMany(t => t.PurchaseOrderDetails)
                .HasForeignKey(d => d.MaterialClassifiedId);
            HasRequired(t => t.MaterialType)
                .WithMany(t => t.PurchaseOrderDetails)
                .HasForeignKey(d => d.MaterialTypeId);
            HasRequired(t => t.PurchaseOrder)
                .WithMany(t => t.PurchaseOrderDetails)
                .HasForeignKey(d => d.PurchaseOrderId);

        }
    }
}
