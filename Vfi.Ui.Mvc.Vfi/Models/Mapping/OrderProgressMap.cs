using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class OrderProgressMap : EntityTypeConfiguration<OrderProgress>
    {
        public OrderProgressMap()
        {
            // Primary Key
            this.HasKey(t => t.ProgressId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrderProgress", "Production");
            this.Property(t => t.ProgressId).HasColumnName("ProgressId");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.Month).HasColumnName("Month");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.ExpectedDay).HasColumnName("ExpectedDay");
            this.Property(t => t.ExpectedFactor).HasColumnName("ExpectedFactor");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.OrderDetailId).HasColumnName("OrderDetailId");
            this.Property(t => t.NumberProcess).HasColumnName("NumberProcess");
            this.Property(t => t.ProductivityInDay).HasColumnName("ProductivityInDay");
            this.Property(t => t.ProcessIndex).HasColumnName("ProcessIndex");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.OrderProgresses)
                .HasForeignKey(d => d.WarehouseId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.OrderProgresses)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
