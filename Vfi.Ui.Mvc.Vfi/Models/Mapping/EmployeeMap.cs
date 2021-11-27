using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeId);

            // Properties
            this.Property(t => t.EmployeeCode)
                .HasMaxLength(50);

            this.Property(t => t.EmployeeName)
                .HasMaxLength(255);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.GroupName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Employee", "Sales");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.EmployeeCode).HasColumnName("EmployeeCode");
            this.Property(t => t.EmployeeName).HasColumnName("EmployeeName");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Production2).HasColumnName("Production2");
            this.Property(t => t.Production2B).HasColumnName("Production2B");
            this.Property(t => t.Repair).HasColumnName("Repair");
            this.Property(t => t.QcLine).HasColumnName("QcLine");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
        }
    }
}
