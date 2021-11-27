using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class CustomerTypeMap : EntityTypeConfiguration<CustomerType>
    {
        public CustomerTypeMap()
        {
            // Primary Key
            HasKey(t => t.CustomerTypeId);

            // Properties
            Property(t => t.CustomerTypeName)
                .HasMaxLength(200);

            Property(t => t.Note)
                .HasMaxLength(500);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("CustomerType", "Sales");
            Property(t => t.CustomerTypeId).HasColumnName("CustomerTypeId");
            Property(t => t.CustomerTypeName).HasColumnName("CustomerTypeName");
            Property(t => t.Note).HasColumnName("Note");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
