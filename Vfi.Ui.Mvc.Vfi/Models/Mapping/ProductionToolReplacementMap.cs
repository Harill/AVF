using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductionToolReplacementMap : EntityTypeConfiguration<ProductionToolReplacement>
    {
        public ProductionToolReplacementMap()
        {
            // Primary Key
            this.HasKey(t => t.ReplaceId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionToolReplacement", "Factory");
            this.Property(t => t.ReplaceId).HasColumnName("ReplaceId");
            this.Property(t => t.TrackId).HasColumnName("TrackId");
            this.Property(t => t.ToolId).HasColumnName("ToolId");
            this.Property(t => t.ProductionToolId).HasColumnName("ProductionToolId");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.PrepareQuantity).HasColumnName("PrepareQuantity");

            // Relationships
            this.HasOptional(t => t.Tool)
                .WithMany(t => t.ProductionToolReplacements)
                .HasForeignKey(d => d.ToolId);
            this.HasRequired(t => t.TrackUpMachine)
                .WithMany(t => t.ProductionToolReplacements)
                .HasForeignKey(d => d.TrackId);

        }
    }
}
