using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class WorkGroupMap : EntityTypeConfiguration<WorkGroup>
    {
        public WorkGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkGroupId);

            // Properties
            this.Property(t => t.WorkGroupCode)
                .HasMaxLength(50);

            this.Property(t => t.WorkGroupName)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WorkGroup", "System");
            this.Property(t => t.WorkGroupId).HasColumnName("WorkGroupId");
            this.Property(t => t.WorkGroupCode).HasColumnName("WorkGroupCode");
            this.Property(t => t.WorkGroupName).HasColumnName("WorkGroupName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
