using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SectionProcessMap : EntityTypeConfiguration<SectionProcess>
    {
        public SectionProcessMap()
        {
            // Primary Key
            this.HasKey(t => t.ProcessId);

            // Properties
            this.Property(t => t.ProcessName)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SectionProcess", "Factory");
            this.Property(t => t.ProcessId).HasColumnName("ProcessId");
            this.Property(t => t.ProcessName).HasColumnName("ProcessName");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.StartProcess).HasColumnName("StartProcess");
            this.Property(t => t.EndProcess).HasColumnName("EndProcess");
        }
    }
}
