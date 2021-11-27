using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ScrapReasonMap : EntityTypeConfiguration<ScrapReason>
    {
        public ScrapReasonMap()
        {
            // Primary Key
            this.HasKey(t => t.ScrapReasonId);

            // Properties
            this.Property(t => t.ScrapReasonName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ScrapReasons", "Purchasing");
            this.Property(t => t.ScrapReasonId).HasColumnName("ScrapReasonId");
            this.Property(t => t.ScrapReasonName).HasColumnName("ScrapReasonName");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
