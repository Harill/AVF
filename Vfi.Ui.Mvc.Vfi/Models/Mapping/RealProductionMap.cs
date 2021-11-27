using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class RealProductionMap : EntityTypeConfiguration<RealProduction>
    {
        public RealProductionMap()
        {
            // Primary Key
            this.HasKey(t => t.RealId);

            // Properties
            // Table & Column Mappings
            this.ToTable("RealProduction", "Factory");
            this.Property(t => t.RealId).HasColumnName("RealId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.TrackUpId).HasColumnName("TrackUpId");

            // Relationships
            this.HasOptional(t => t.Machine)
                .WithMany(t => t.RealProductions)
                .HasForeignKey(d => d.MachineId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.RealProductions)
                .HasForeignKey(d => d.ProductId);
            this.HasOptional(t => t.TrackUpMachine)
                .WithMany(t => t.RealProductions)
                .HasForeignKey(d => d.TrackUpId);

        }
    }
}
