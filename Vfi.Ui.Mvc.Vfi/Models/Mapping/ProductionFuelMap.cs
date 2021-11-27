using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionFuelMap : EntityTypeConfiguration<ProductionFuel>
    {
        public ProductionFuelMap()
        {
            // Primary Key
            this.HasKey(t => t.RealId);

            // Properties
            this.Property(t => t.Note)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionFuel", "Factory");
            this.Property(t => t.RealId).HasColumnName("RealId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.FuelId).HasColumnName("FuelId");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.Quota).HasColumnName("Quota");
            this.Property(t => t.Quota2).HasColumnName("Quota2");
            this.Property(t => t.Fuel2Id).HasColumnName("Fuel2Id");
            this.Property(t => t.CrossWeight).HasColumnName("CrossWeight");
            this.Property(t => t.CrossWeight2).HasColumnName("CrossWeight2");

            // Relationships
            this.HasRequired(t => t.Fuel)
                .WithMany(t => t.ProductionFuels)
                .HasForeignKey(d => d.FuelId);
            this.HasOptional(t => t.Fuel1)
                .WithMany(t => t.ProductionFuels1)
                .HasForeignKey(d => d.Fuel2Id);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductionFuels)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
