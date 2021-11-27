using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class StockOrderDetailMap : EntityTypeConfiguration<StockOrderDetail>
    {
        public StockOrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.StockOrderDetailId);

            // Properties
            this.Property(t => t.UnitMeasure)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StockOrderDetail", "Inv");
            this.Property(t => t.StockOrderDetailId).HasColumnName("StockOrderDetailId");
            this.Property(t => t.StockOrderId).HasColumnName("StockOrderId");
            this.Property(t => t.ReferenceId).HasColumnName("ReferenceId");
            this.Property(t => t.MoP).HasColumnName("MoP");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.UnitMeasure).HasColumnName("UnitMeasure");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.Material)
                .WithMany(t => t.StockOrderDetails)
                .HasForeignKey(d => d.ReferenceId);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.StockOrderDetails)
                .HasForeignKey(d => d.ReferenceId);

        }
    }
}
