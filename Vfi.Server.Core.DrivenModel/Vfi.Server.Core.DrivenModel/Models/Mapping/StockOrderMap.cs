using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class StockOrderMap : EntityTypeConfiguration<StockOrder>
    {
        public StockOrderMap()
        {
            // Primary Key
            HasKey(t => t.StockOrderId);

            // Properties
            Property(t => t.StockOrderCode)
                .HasMaxLength(50);

            Property(t => t.EoI)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("StockOrder", "Inv");
            Property(t => t.StockOrderId).HasColumnName("StockOrderId");
            Property(t => t.WarehouseIssueId).HasColumnName("WarehouseIssueId");
            Property(t => t.WarehouseReceiptId).HasColumnName("WarehouseReceiptId");
            Property(t => t.StockOrderTypeId).HasColumnName("StockOrderTypeId");
            Property(t => t.StockOrderCode).HasColumnName("StockOrderCode");
            Property(t => t.EoI).HasColumnName("EoI");
            Property(t => t.MoP).HasColumnName("MoP");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.Status).HasColumnName("Status");
            Property(t => t.IsApprove).HasColumnName("IsApprove");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasOptional(t => t.Warehouse)
                .WithMany(t => t.StockOrders)
                .HasForeignKey(d => d.WarehouseIssueId);
            HasOptional(t => t.Warehouse1)
                .WithMany(t => t.StockOrders1)
                .HasForeignKey(d => d.WarehouseReceiptId);

        }
    }
}
