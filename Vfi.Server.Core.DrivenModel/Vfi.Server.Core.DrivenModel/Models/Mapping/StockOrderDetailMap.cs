using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class StockOrderDetailMap : EntityTypeConfiguration<StockOrderDetail>
    {
        public StockOrderDetailMap()
        {
            // Primary Key
            HasKey(t => t.StockOrderDetailId);

            // Properties
            Property(t => t.UnitMeasure)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("StockOrderDetail", "Inv");
            Property(t => t.StockOrderDetailId).HasColumnName("StockOrderDetailId");
            Property(t => t.StockOrderId).HasColumnName("StockOrderId");
            Property(t => t.ReferenceId).HasColumnName("ReferenceId");
            Property(t => t.MoP).HasColumnName("MoP");
            Property(t => t.Quantity).HasColumnName("Quantity");
            Property(t => t.UnitMeasure).HasColumnName("UnitMeasure");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasOptional(t => t.Material)
                .WithMany(t => t.StockOrderDetails)
                .HasForeignKey(d => d.ReferenceId);
            HasOptional(t => t.Product)
                .WithMany(t => t.StockOrderDetails)
                .HasForeignKey(d => d.ReferenceId);

        }
    }
}
