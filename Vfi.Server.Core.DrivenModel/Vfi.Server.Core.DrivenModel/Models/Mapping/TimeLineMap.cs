using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class TimeLineMap : EntityTypeConfiguration<TimeLine>
    {
        public TimeLineMap()
        {
            // Primary Key
            HasKey(t => t.TimeLineId);

            // Properties
            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("TimeLine", "Sales");
            Property(t => t.TimeLineId).HasColumnName("TimeLineId");
            Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            Property(t => t.SalesOrderDetailId).HasColumnName("SalesOrderDetailId");
            Property(t => t.Times).HasColumnName("Times");
            Property(t => t.RealTimes).HasColumnName("RealTimes");
            Property(t => t.Performance).HasColumnName("Performance");
            Property(t => t.StartDay).HasColumnName("StartDay");
            Property(t => t.FinishedDay).HasColumnName("FinishedDay");
            Property(t => t.WorkingHours).HasColumnName("WorkingHours");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasOptional(t => t.Warehouse)
                .WithMany(t => t.TimeLines)
                .HasForeignKey(d => d.WarehouseId);
            HasOptional(t => t.SalesOrderDetail)
                .WithMany(t => t.TimeLines)
                .HasForeignKey(d => d.SalesOrderDetailId);

        }
    }
}
