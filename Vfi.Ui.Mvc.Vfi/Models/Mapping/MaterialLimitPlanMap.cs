using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MaterialLimitPlanMap : EntityTypeConfiguration<MaterialLimitPlan>
    {
        public MaterialLimitPlanMap()
        {
            // Primary Key
            this.HasKey(t => t.LimitId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaterialLimitPlan", "Factory");
            this.Property(t => t.LimitId).HasColumnName("LimitId");
            this.Property(t => t.MaterialId).HasColumnName("MaterialId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.MaterialLimitQuantity).HasColumnName("MaterialLimitQuantity");
            this.Property(t => t.ProductLimitQuantity).HasColumnName("ProductLimitQuantity");
            this.Property(t => t.Productivity).HasColumnName("Productivity");
            this.Property(t => t.ApplyDate).HasColumnName("ApplyDate");
            this.Property(t => t.IsLock).HasColumnName("IsLock");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.RawProductionWeight).HasColumnName("RawProductionWeight");
            this.Property(t => t.EstimateLossPercent).HasColumnName("EstimateLossPercent");
            this.Property(t => t.WorkpieceLossPercent).HasColumnName("WorkpieceLossPercent");
            this.Property(t => t.ExpiredDay).HasColumnName("ExpiredDay");

            // Relationships
            this.HasRequired(t => t.Material)
                .WithMany(t => t.MaterialLimitPlans)
                .HasForeignKey(d => d.MaterialId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.MaterialLimitPlans)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
