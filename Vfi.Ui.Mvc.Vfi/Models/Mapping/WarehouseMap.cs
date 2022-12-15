using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class WarehouseMap : EntityTypeConfiguration<Warehouse>
    {
        public WarehouseMap()
        {
            // Primary Key
            this.HasKey(t => t.WarehouseId);

            // Properties
            this.Property(t => t.WarehouseName)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.ShortName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Warehouse", "Inv");
            this.Property(t => t.WarehouseId).HasColumnName("WarehouseId");
            this.Property(t => t.WarehouseTypeId).HasColumnName("WarehouseTypeId");
            this.Property(t => t.WarehouseName).HasColumnName("WarehouseName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.DisplayInReport).HasColumnName("DisplayInReport");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ShortName).HasColumnName("ShortName");
            this.Property(t => t.CanInternal).HasColumnName("CanInternal");
            this.Property(t => t.CanPurchase).HasColumnName("CanPurchase");
            this.Property(t => t.IsHeatTreatment).HasColumnName("IsHeatTreatment");
            this.Property(t => t.IsPolish).HasColumnName("IsPolish");
            this.Property(t => t.IsReprocessing).HasColumnName("IsReprocessing");
            this.Property(t => t.IsProduction2).HasColumnName("IsProduction2");
            this.Property(t => t.IsProduction2Process).HasColumnName("IsProduction2Process");
            this.Property(t => t.IsMainProcess).HasColumnName("IsMainProcess");
            this.Property(t => t.IsQC).HasColumnName("IsQC");
            this.Property(t => t.IsPlating).HasColumnName("IsPlating");
            this.Property(t => t.IsOutOfProcess).HasColumnName("IsOutOfProcess");
            this.Property(t => t.CanStock).HasColumnName("CanStock");
            this.Property(t => t.IsProduction).HasColumnName("IsProduction");
            this.Property(t => t.IsCncMilling).HasColumnName("IsCncMilling");
            this.Property(t => t.CanWeighing).HasColumnName("CanWeighing");
            this.Property(t => t.IsPacking).HasColumnName("IsPacking");
            this.Property(t => t.IsFinish).HasColumnName("IsFinish");
            this.Property(t => t.AutoGenerateProcess).HasColumnName("AutoGenerateProcess");

            // Relationships
            this.HasOptional(t => t.WarehouseType)
                .WithMany(t => t.Warehouses)
                .HasForeignKey(d => d.WarehouseTypeId);

        }
    }
}
