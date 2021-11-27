using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class StockOrderMap : EntityTypeConfiguration<StockOrder>
    {
        public StockOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.StockOrderId);

            // Properties
            this.Property(t => t.StockOrderCode)
                .HasMaxLength(50);

            this.Property(t => t.EoI)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CreatedUser)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StockOrder", "Inv");
            this.Property(t => t.StockOrderId).HasColumnName("StockOrderId");
            this.Property(t => t.WarehouseIssueId).HasColumnName("WarehouseIssueId");
            this.Property(t => t.WarehouseReceiptId).HasColumnName("WarehouseReceiptId");
            this.Property(t => t.StockOrderTypeId).HasColumnName("StockOrderTypeId");
            this.Property(t => t.StockOrderCode).HasColumnName("StockOrderCode");
            this.Property(t => t.EoI).HasColumnName("EoI");
            this.Property(t => t.MoP).HasColumnName("MoP");
            this.Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.IsApprove).HasColumnName("IsApprove");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.Warehouse)
                .WithMany(t => t.StockOrders)
                .HasForeignKey(d => d.WarehouseIssueId);
            this.HasOptional(t => t.Warehouse1)
                .WithMany(t => t.StockOrders1)
                .HasForeignKey(d => d.WarehouseReceiptId);

        }
    }
}
