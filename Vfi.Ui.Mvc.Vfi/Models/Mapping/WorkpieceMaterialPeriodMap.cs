using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class WorkpieceMaterialPeriodMap : EntityTypeConfiguration<WorkpieceMaterialPeriod>
    {
        public WorkpieceMaterialPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodId);

            // Properties
            this.Property(t => t.IdentityCode)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WorkpieceMaterialPeriod", "Factory");
            this.Property(t => t.PeriodId).HasColumnName("PeriodId");
            this.Property(t => t.IdentityCode).HasColumnName("IdentityCode");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.EoIId).HasColumnName("EoIId");
            this.Property(t => t.EoI).HasColumnName("EoI");
            this.Property(t => t.PeriodDate).HasColumnName("PeriodDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.EarlyQuantity).HasColumnName("EarlyQuantity");
            this.Property(t => t.LastQuantity).HasColumnName("LastQuantity");
            this.Property(t => t.IsDestroy).HasColumnName("IsDestroy");
            this.Property(t => t.ExportType).HasColumnName("ExportType");

            // Relationships
            this.HasOptional(t => t.ExportWorkpieceMaterial)
                .WithMany(t => t.WorkpieceMaterialPeriods)
                .HasForeignKey(d => d.EoIId);
            this.HasOptional(t => t.ImportWorkpieceMaterial)
                .WithMany(t => t.WorkpieceMaterialPeriods)
                .HasForeignKey(d => d.EoIId);

        }
    }
}
