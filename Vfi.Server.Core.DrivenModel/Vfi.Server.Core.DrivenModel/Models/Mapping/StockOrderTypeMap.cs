using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class StockOrderTypeMap : EntityTypeConfiguration<StockOrderType>
    {
        public StockOrderTypeMap()
        {
            // Primary Key
            HasKey(t => t.StockOrderTypeId);

            // Properties
            Property(t => t.StockOrderTypeName)
                .HasMaxLength(255);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("StockOrderType", "Inv");
            Property(t => t.StockOrderTypeId).HasColumnName("StockOrderTypeId");
            Property(t => t.StockOrderTypeName).HasColumnName("StockOrderTypeName");
            Property(t => t.EoI).HasColumnName("EoI");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
