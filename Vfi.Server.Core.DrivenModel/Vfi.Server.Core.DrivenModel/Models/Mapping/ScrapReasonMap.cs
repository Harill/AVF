using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class ScrapReasonMap : EntityTypeConfiguration<ScrapReason>
    {
        public ScrapReasonMap()
        {
            // Primary Key
            HasKey(t => t.ScrapReasonId);

            // Properties
            Property(t => t.ScrapReasonName)
                .IsRequired()
                .HasMaxLength(500);

            Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ScrapReasons", "Purchasing");
            Property(t => t.ScrapReasonId).HasColumnName("ScrapReasonId");
            Property(t => t.ScrapReasonName).HasColumnName("ScrapReasonName");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
