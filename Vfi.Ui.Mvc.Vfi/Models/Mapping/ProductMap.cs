using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductId);

            // Properties
            this.Property(t => t.ProductCode)
                .HasMaxLength(50);

            this.Property(t => t.ProductName)
                .HasMaxLength(255);

            this.Property(t => t.DesignNo)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.MaterialNameDesign)
                .HasMaxLength(50);

            this.Property(t => t.OutDiameterTolerance)
                .HasMaxLength(50);

            this.Property(t => t.InDiameterTolerance)
                .HasMaxLength(50);

            this.Property(t => t.ShapeDesign)
                .HasMaxLength(50);

            this.Property(t => t.DiameterTypeDesign)
                .HasMaxLength(50);

            this.Property(t => t.UploadUser)
                .HasMaxLength(50);

            this.Property(t => t.ProductShape)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Currency)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.IdentityCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Product", "Production");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.MaterialId).HasColumnName("MaterialId");
            this.Property(t => t.ProductCode).HasColumnName("ProductCode");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.DesignNo).HasColumnName("DesignNo");
            this.Property(t => t.Diameter).HasColumnName("Diameter");
            this.Property(t => t.Length).HasColumnName("Length");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ForecastsQuality).HasColumnName("ForecastsQuality");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.ProductionWeight).HasColumnName("ProductionWeight");
            this.Property(t => t.ProductionRate).HasColumnName("ProductionRate");
            this.Property(t => t.Productivity).HasColumnName("Productivity");
            this.Property(t => t.SaleFactor).HasColumnName("SaleFactor");
            this.Property(t => t.ProductionFactor).HasColumnName("ProductionFactor");
            this.Property(t => t.CncWeight).HasColumnName("CncWeight");
            this.Property(t => t.Production2Weight).HasColumnName("Production2Weight");
            this.Property(t => t.WaitingPlatingWeight).HasColumnName("WaitingPlatingWeight");
            this.Property(t => t.PlatingWeight).HasColumnName("PlatingWeight");
            this.Property(t => t.QcWeight).HasColumnName("QcWeight");
            this.Property(t => t.FinishWeight).HasColumnName("FinishWeight");
            this.Property(t => t.OutsideProcessWeight).HasColumnName("OutsideProcessWeight");
            this.Property(t => t.HeatTreatmentWeight).HasColumnName("HeatTreatmentWeight");
            this.Property(t => t.SurfaceTreatmentWeight).HasColumnName("SurfaceTreatmentWeight");
            this.Property(t => t.IsSelling).HasColumnName("IsSelling");
            this.Property(t => t.MaterialNameDesign).HasColumnName("MaterialNameDesign");
            this.Property(t => t.OutDiameterDesign).HasColumnName("OutDiameterDesign");
            this.Property(t => t.OutDiameterTolerance).HasColumnName("OutDiameterTolerance");
            this.Property(t => t.InDiameterDesign).HasColumnName("InDiameterDesign");
            this.Property(t => t.InDiameterTolerance).HasColumnName("InDiameterTolerance");
            this.Property(t => t.ShapeDesign).HasColumnName("ShapeDesign");
            this.Property(t => t.NewUpdateDate).HasColumnName("NewUpdateDate");
            this.Property(t => t.LastSaleFactor).HasColumnName("LastSaleFactor");
            this.Property(t => t.LastUpdateDate).HasColumnName("LastUpdateDate");
            this.Property(t => t.LastMonthSaleFactor).HasColumnName("LastMonthSaleFactor");
            this.Property(t => t.LastMonthUpdateDate).HasColumnName("LastMonthUpdateDate");
            this.Property(t => t.FinishProcessingDate).HasColumnName("FinishProcessingDate");
            this.Property(t => t.Drawing2D).HasColumnName("Drawing2D");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Diff).HasColumnName("Diff");
            this.Property(t => t.ProcessingDesign).HasColumnName("ProcessingDesign");
            this.Property(t => t.ProcessingCost).HasColumnName("ProcessingCost");
            this.Property(t => t.DiameterTypeDesign).HasColumnName("DiameterTypeDesign");
            this.Property(t => t.DrawingFinish).HasColumnName("DrawingFinish");
            this.Property(t => t.KnifeCut).HasColumnName("KnifeCut");
            this.Property(t => t.UploadUser).HasColumnName("UploadUser");
            this.Property(t => t.UploadDate).HasColumnName("UploadDate");
            this.Property(t => t.MillProductivity).HasColumnName("MillProductivity");
            this.Property(t => t.MaterialCost).HasColumnName("MaterialCost");
            this.Property(t => t.DiffRequestInv).HasColumnName("DiffRequestInv");
            this.Property(t => t.QcProductivity).HasColumnName("QcProductivity");
            this.Property(t => t.ProductShape).HasColumnName("ProductShape");
            this.Property(t => t.CncProductivity).HasColumnName("CncProductivity");
            this.Property(t => t.TaxCode).HasColumnName("TaxCode");
            this.Property(t => t.FinishDesign).HasColumnName("FinishDesign");
            this.Property(t => t.MachineFunction).HasColumnName("MachineFunction");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.BaseProductId).HasColumnName("BaseProductId");
            this.Property(t => t.MaxQuantityInTray).HasColumnName("MaxQuantityInTray");
            this.Property(t => t.MaxQuantityInTrayRunTime).HasColumnName("MaxQuantityInTrayRunTime");
            this.Property(t => t.IdentityCode).HasColumnName("IdentityCode");
            this.Property(t => t.ProductionLevel).HasColumnName("ProductionLevel");
            this.Property(t => t.ProcessClassifiedId).HasColumnName("ProcessClassifiedId");
            this.Property(t => t.PackingFee).HasColumnName("PackingFee");
            this.Property(t => t.IsCalculateLock).HasColumnName("IsCalculateLock");
            this.Property(t => t.ProductionLossRate).HasColumnName("ProductionLossRate");

            // Relationships
            this.HasOptional(t => t.ProcessClassified)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.ProcessClassifiedId);
            this.HasOptional(t => t.ProcessingType)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.ProcessingDesign);
            this.HasOptional(t => t.ProductionProductLevel)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.ProductionLevel);
            this.HasOptional(t => t.Material)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.MaterialId);
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.CustomerId);

        }
    }
}
