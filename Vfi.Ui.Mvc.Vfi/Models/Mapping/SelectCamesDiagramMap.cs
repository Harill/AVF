using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SelectCamesDiagramMap : EntityTypeConfiguration<SelectCamesDiagram>
    {
        public SelectCamesDiagramMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MachineId, t.ProductId, t.TrackId, t.Expr1, t.Expr2, t.RoundPerMinute, t.RealProductivity, t.RealRate, t.WorkPiece, t.KnifeCut, t.Status, t.ModifiedDate, t.StartDate, t.Quantity, t.EndDate, t.ForecastDay, t.ForecastDate });

            // Properties
            this.Property(t => t.MachineId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MachineName)
                .HasMaxLength(150);

            this.Property(t => t.ProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductCode)
                .HasMaxLength(50);

            this.Property(t => t.WarrningColor)
                .HasMaxLength(50);

            this.Property(t => t.MaterialCode)
                .HasMaxLength(50);

            this.Property(t => t.TrackId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Phase)
                .HasMaxLength(50);

            this.Property(t => t.RoundPerMinute)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RealRate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DeliveryEmployee)
                .HasMaxLength(50);

            this.Property(t => t.ReceiveEmployee)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.Quantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ForecastDay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SelectCamesDiagram");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.MaxDate).HasColumnName("MaxDate");
            this.Property(t => t.MachineName).HasColumnName("MachineName");
            this.Property(t => t.DiagramType).HasColumnName("DiagramType");
            this.Property(t => t.ColumnIndex).HasColumnName("ColumnIndex");
            this.Property(t => t.RowIndex).HasColumnName("RowIndex");
            this.Property(t => t.ProcessingTypeId).HasColumnName("ProcessingTypeId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductCode).HasColumnName("ProductCode");
            this.Property(t => t.WarrningColor).HasColumnName("WarrningColor");
            this.Property(t => t.MaterialCode).HasColumnName("MaterialCode");
            this.Property(t => t.TrackId).HasColumnName("TrackId");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.Expr1).HasColumnName("Expr1");
            this.Property(t => t.Expr2).HasColumnName("Expr2");
            this.Property(t => t.Phase).HasColumnName("Phase");
            this.Property(t => t.RoundPerMinute).HasColumnName("RoundPerMinute");
            this.Property(t => t.RealProductivity).HasColumnName("RealProductivity");
            this.Property(t => t.RealRate).HasColumnName("RealRate");
            this.Property(t => t.WorkPiece).HasColumnName("WorkPiece");
            this.Property(t => t.KnifeCut).HasColumnName("KnifeCut");
            this.Property(t => t.DeliveryEmployee).HasColumnName("DeliveryEmployee");
            this.Property(t => t.ReceiveEmployee).HasColumnName("ReceiveEmployee");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.MaterialId).HasColumnName("MaterialId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.ForecastDay).HasColumnName("ForecastDay");
            this.Property(t => t.ForecastDate).HasColumnName("ForecastDate");
        }
    }
}
