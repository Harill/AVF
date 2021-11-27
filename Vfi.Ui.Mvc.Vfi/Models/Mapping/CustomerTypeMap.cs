using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class CustomerTypeMap : EntityTypeConfiguration<CustomerType>
    {
        public CustomerTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerTypeId);

            // Properties
            this.Property(t => t.CustomerTypeName)
                .HasMaxLength(200);

            this.Property(t => t.Note)
                .HasMaxLength(500);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CustomerType", "Sales");
            this.Property(t => t.CustomerTypeId).HasColumnName("CustomerTypeId");
            this.Property(t => t.CustomerTypeName).HasColumnName("CustomerTypeName");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
