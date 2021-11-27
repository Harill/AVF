using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class PlatingFormDetailMap : EntityTypeConfiguration<PlatingFormDetail>
    {
        public PlatingFormDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.PlatingCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Thickness)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SaltSprayTime)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SpecialRequest)
                .IsRequired();

            this.Property(t => t.Sample)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TestingEquipment)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PlatingFormDetail", "Purchasing");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.PlatingCode).HasColumnName("PlatingCode");
            this.Property(t => t.Thickness).HasColumnName("Thickness");
            this.Property(t => t.SaltSprayTime).HasColumnName("SaltSprayTime");
            this.Property(t => t.SpecialRequest).HasColumnName("SpecialRequest");
            this.Property(t => t.Sample).HasColumnName("Sample");
            this.Property(t => t.TestingEquipment).HasColumnName("TestingEquipment");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.QuantityRequirement).HasColumnName("QuantityRequirement");
            this.Property(t => t.ExportDateRequirement).HasColumnName("ExportDateRequirement");
            this.Property(t => t.ImportDateRequirement).HasColumnName("ImportDateRequirement");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.PlatingFormDetails)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.PlatingForm)
                .WithMany(t => t.PlatingFormDetails)
                .HasForeignKey(d => d.FormId);

        }
    }
}
