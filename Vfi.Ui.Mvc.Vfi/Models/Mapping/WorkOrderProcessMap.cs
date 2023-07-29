using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class WorkOrderProcessMap : EntityTypeConfiguration<WorkOrderProcess>
    {
        public WorkOrderProcessMap()
        {
            // Primary Key
            this.HasKey(t => t.ProcessId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WorkOrderProcess", "Factory");
            this.Property(t => t.ProcessId).HasColumnName("ProcessId");
            this.Property(t => t.RoutingId).HasColumnName("RoutingId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.UsingQuantity).HasColumnName("UsingQuantity");
            this.Property(t => t.GoodQuantity).HasColumnName("GoodQuantity");
            this.Property(t => t.NGQuantity).HasColumnName("NGQuantity");
            this.Property(t => t.DefectQuantity).HasColumnName("DefectQuantity");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.ReferenceDetailId).HasColumnName("ReferenceDetailId");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.UnitWeight).HasColumnName("UnitWeight");
            this.Property(t => t.ProcessNote).HasColumnName("ProcessNote");

            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.WorkOrderProcesses)
                .HasForeignKey(d => d.EmployeeId);
            this.HasRequired(t => t.WorkOrderRouting)
                .WithMany(t => t.WorkOrderProcesses)
                .HasForeignKey(d => d.RoutingId);

        }
    }
}
