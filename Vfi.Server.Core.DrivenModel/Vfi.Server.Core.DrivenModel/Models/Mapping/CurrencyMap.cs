
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class CurrencyMap : EntityTypeConfiguration<Currency>
    {
        public CurrencyMap()
        {
            // Primary Key
            HasKey(t => t.CurrencyCode);

            // Properties
            Property(t => t.CurrencyCode)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.CurrencyName)
                .HasMaxLength(150);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Currency", "Production");
            Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
            Property(t => t.CurrencyName).HasColumnName("CurrencyName");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
