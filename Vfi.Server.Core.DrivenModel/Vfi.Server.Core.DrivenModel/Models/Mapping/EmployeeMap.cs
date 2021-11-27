using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            HasKey(t => t.EmployeeId);

            // Properties
            Property(t => t.EmployeeCode)
                .HasMaxLength(50);

            Property(t => t.EmployeeName)
                .HasMaxLength(255);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Employee", "Sales");
            Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            Property(t => t.EmployeeCode).HasColumnName("EmployeeCode");
            Property(t => t.EmployeeName).HasColumnName("EmployeeName");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
