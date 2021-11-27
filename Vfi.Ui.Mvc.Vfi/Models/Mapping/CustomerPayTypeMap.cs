using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class CustomerPayTypeMap : EntityTypeConfiguration<CustomerPayType>
    {
        public CustomerPayTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TypeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CustomerPayType", "Sales");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
        }
    }
}
