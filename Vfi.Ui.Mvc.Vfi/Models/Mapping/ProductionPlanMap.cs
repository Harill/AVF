using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionPlanMap : EntityTypeConfiguration<ProductionPlan>
    {
        public ProductionPlanMap()
        {
            // Primary Key
            this.HasKey(t => t.PlanId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionPlan");
            this.Property(t => t.PlanId).HasColumnName("PlanId");
            this.Property(t => t.PlanDate).HasColumnName("PlanDate");
            this.Property(t => t.PlanType).HasColumnName("PlanType");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.RequireQuantity).HasColumnName("RequireQuantity");
            this.Property(t => t.ProductivityInDay).HasColumnName("ProductivityInDay");
            this.Property(t => t.RequireQuantityPerDay).HasColumnName("RequireQuantityPerDay");
            this.Property(t => t.MachineFactor).HasColumnName("MachineFactor");
            this.Property(t => t.Day1).HasColumnName("Day1");
            this.Property(t => t.Day2).HasColumnName("Day2");
            this.Property(t => t.Day3).HasColumnName("Day3");
            this.Property(t => t.Day4).HasColumnName("Day4");
            this.Property(t => t.Day5).HasColumnName("Day5");
            this.Property(t => t.Day6).HasColumnName("Day6");
            this.Property(t => t.Day7).HasColumnName("Day7");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductionPlans)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.ProductionPlans)
                .HasForeignKey(d => d.PlanType);

        }
    }
}
