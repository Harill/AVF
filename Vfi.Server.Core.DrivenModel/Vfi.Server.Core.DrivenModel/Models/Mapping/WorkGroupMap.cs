using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class WorkGroupMap : EntityTypeConfiguration<WorkGroup>
    {
        public WorkGroupMap()
        {
            // Primary Key
            HasKey(t => t.WorkGroupId);

            // Properties
            Property(t => t.WorkGroupCode)
                .HasMaxLength(50);

            Property(t => t.WorkGroupName)
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("WorkGroup", "System");
            Property(t => t.WorkGroupId).HasColumnName("WorkGroupId");
            Property(t => t.WorkGroupCode).HasColumnName("WorkGroupCode");
            Property(t => t.WorkGroupName).HasColumnName("WorkGroupName");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
