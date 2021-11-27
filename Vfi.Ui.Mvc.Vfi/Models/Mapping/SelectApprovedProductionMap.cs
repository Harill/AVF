using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SelectApprovedProductionMap : EntityTypeConfiguration<SelectApprovedProduction>
    {
        public SelectApprovedProductionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MaterialWeight, t.MaterialId, t.ProductionRate, t.ProductId, t.ProductWeight, t.ImportDate, t.MaterialUseDate });

            // Properties
            this.Property(t => t.MaterialId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductionRate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MachineName)
                .HasMaxLength(150);

            this.Property(t => t.ProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SelectApprovedProduction");
            this.Property(t => t.MaterialInvId).HasColumnName("MaterialInvId");
            this.Property(t => t.MaterialWeight).HasColumnName("MaterialWeight");
            this.Property(t => t.MaterialId).HasColumnName("MaterialId");
            this.Property(t => t.ProductionRate).HasColumnName("ProductionRate");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.MachineName).HasColumnName("MachineName");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductCode).HasColumnName("ProductCode");
            this.Property(t => t.ProductWeight).HasColumnName("ProductWeight");
            this.Property(t => t.ImportDate).HasColumnName("ImportDate");
            this.Property(t => t.MaterialUseDate).HasColumnName("MaterialUseDate");
            this.Property(t => t.MaterialUse).HasColumnName("MaterialUse");
            this.Property(t => t.Number).HasColumnName("Number");
            this.Property(t => t.Processing).HasColumnName("Processing");
            this.Property(t => t.Defect).HasColumnName("Defect");
            this.Property(t => t.ProductionDiff).HasColumnName("ProductionDiff");
        }
    }
}
