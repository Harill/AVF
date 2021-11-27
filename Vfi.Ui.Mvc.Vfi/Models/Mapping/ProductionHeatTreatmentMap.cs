using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionHeatTreatmentMap : EntityTypeConfiguration<ProductionHeatTreatment>
    {
        public ProductionHeatTreatmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Note)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionHeatTreatment", "Factory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Section).HasColumnName("Section");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.Timing).HasColumnName("Timing");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Temperature).HasColumnName("Temperature");
            this.Property(t => t.Stiffness).HasColumnName("Stiffness");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.MachineId).HasColumnName("MachineId");

            // Relationships
            this.HasOptional(t => t.Machine)
                .WithMany(t => t.ProductionHeatTreatments)
                .HasForeignKey(d => d.MachineId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductionHeatTreatments)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
