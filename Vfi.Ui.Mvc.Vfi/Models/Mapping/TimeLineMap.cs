using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class TimeLineMap : EntityTypeConfiguration<TimeLine>
    {
        public TimeLineMap()
        {
            // Primary Key
            this.HasKey(t => t.TimeLineId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TimeLine", "Sales");
            this.Property(t => t.TimeLineId).HasColumnName("TimeLineId");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.OrderDetailId).HasColumnName("OrderDetailId");
            this.Property(t => t.Times).HasColumnName("Times");
            this.Property(t => t.RealTimes).HasColumnName("RealTimes");
            this.Property(t => t.Performance).HasColumnName("Performance");
            this.Property(t => t.StartDay).HasColumnName("StartDay");
            this.Property(t => t.FinishedDay).HasColumnName("FinishedDay");
            this.Property(t => t.WorkingHours).HasColumnName("WorkingHours");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.Warehouse)
                .WithMany(t => t.TimeLines)
                .HasForeignKey(d => d.WarehouseId);
            this.HasOptional(t => t.OrderDetail)
                .WithMany(t => t.TimeLines)
                .HasForeignKey(d => d.OrderDetailId);

        }
    }
}
