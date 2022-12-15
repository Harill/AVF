using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionPlatingMap : EntityTypeConfiguration<ProductionPlating>
    {
        public ProductionPlatingMap()
        {
            // Primary Key
            this.HasKey(t => t.PlatingId);

            // Properties
            this.Property(t => t.PlatingName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired();

            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InserUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Thickness)
                .HasMaxLength(50);

            this.Property(t => t.SaltSprayTime)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionPlating", "Factory");
            this.Property(t => t.PlatingId).HasColumnName("PlatingId");
            this.Property(t => t.PlatingName).HasColumnName("PlatingName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.PlatingCost).HasColumnName("PlatingCost");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.InsertDate).HasColumnName("InsertDate");
            this.Property(t => t.InserUser).HasColumnName("InserUser");
            this.Property(t => t.PlatingIndex).HasColumnName("PlatingIndex");
            this.Property(t => t.PlatingDay).HasColumnName("PlatingDay");
            this.Property(t => t.Thickness).HasColumnName("Thickness");
            this.Property(t => t.SaltSprayTime).HasColumnName("SaltSprayTime");
            this.Property(t => t.IsMainProcess).HasColumnName("IsMainProcess");
            this.Property(t => t.ProcessId).HasColumnName("ProcessId");

            // Relationships
            this.HasOptional(t => t.OutsideProcess)
                .WithMany(t => t.ProductionPlatings)
                .HasForeignKey(d => d.ProcessId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductionPlatings)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
