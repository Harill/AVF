using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class SalesOrderDetailMap : EntityTypeConfiguration<SalesOrderDetail>
    {
        public SalesOrderDetailMap()
        {
            // Primary Key
            HasKey(t => t.SalesOrderDetailId);

            // Properties
            Property(t => t.PoNoOfCustomer)
                .HasMaxLength(50);

            Property(t => t.LotNoOfCustomer)
                .HasMaxLength(50);

            Property(t => t.ModelNoOfCustomer)
                .HasMaxLength(50);

            Property(t => t.CarrierTrackingNumber)
                .HasMaxLength(25);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("SalesOrderDetail", "Sales");
            Property(t => t.SalesOrderDetailId).HasColumnName("SalesOrderDetailId");
            Property(t => t.SalesOrderId).HasColumnName("SalesOrderId");
            Property(t => t.ProductId).HasColumnName("ProductId");
            Property(t => t.PoNoOfCustomer).HasColumnName("PoNoOfCustomer");
            Property(t => t.LotNoOfCustomer).HasColumnName("LotNoOfCustomer");
            Property(t => t.ModelNoOfCustomer).HasColumnName("ModelNoOfCustomer");
            Property(t => t.CarrierTrackingNumber).HasColumnName("CarrierTrackingNumber");
            Property(t => t.OrderQty).HasColumnName("OrderQty");
            Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            Property(t => t.UnitPriceDiscount).HasColumnName("UnitPriceDiscount");
            Property(t => t.LineTotal).HasColumnName("LineTotal");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Product)
                .WithMany(t => t.SalesOrderDetails)
                .HasForeignKey(d => d.ProductId);
            HasRequired(t => t.SalesOrder)
                .WithMany(t => t.SalesOrderDetails)
                .HasForeignKey(d => d.SalesOrderId);

        }
    }
}
