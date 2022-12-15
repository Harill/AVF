using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MOQTemplateMap : EntityTypeConfiguration<MOQTemplate>
    {
        public MOQTemplateMap()
        {
            // Primary Key
            this.HasKey(t => t.TemplateId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MOQTemplate", "Sales");
            this.Property(t => t.TemplateId).HasColumnName("TemplateId");
            this.Property(t => t.FromQuantity).HasColumnName("FromQuantity");
            this.Property(t => t.ToQuantity).HasColumnName("ToQuantity");
            this.Property(t => t.FactorDefault).HasColumnName("FactorDefault");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
        }
    }
}
