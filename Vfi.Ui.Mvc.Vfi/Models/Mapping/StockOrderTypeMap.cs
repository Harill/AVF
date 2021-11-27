using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class StockOrderTypeMap : EntityTypeConfiguration<StockOrderType>
    {
        public StockOrderTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.StockOrderTypeId);

            // Properties
            this.Property(t => t.StockOrderTypeName)
                .HasMaxLength(255);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StockOrderType", "Inv");
            this.Property(t => t.StockOrderTypeId).HasColumnName("StockOrderTypeId");
            this.Property(t => t.StockOrderTypeName).HasColumnName("StockOrderTypeName");
            this.Property(t => t.EoI).HasColumnName("EoI");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
