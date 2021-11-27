using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class SelectCurrentProductionToolMap : EntityTypeConfiguration<SelectCurrentProductionTool>
    {
        public SelectCurrentProductionToolMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MachineId, t.TrackId, t.Expr1, t.ProductId, t.RoundPerMinute, t.RealProductivity, t.RealRate, t.WorkPiece, t.KnifeCut, t.Status, t.ModifiedDate, t.StartDate, t.Quantity, t.EndDate, t.ForecastDay, t.ForecastDate, t.RealToolId, t.Expr2, t.ToolId, t.UseNumber, t.Active, t.Expr4, t.Quota });

            // Properties
            this.Property(t => t.MachineId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MachineName)
                .HasMaxLength(150);

            this.Property(t => t.TrackId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductId)
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

            this.Property(t => t.RealToolId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ToolId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UseNumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr3)
                .HasMaxLength(50);

            this.Property(t => t.Expr5)
                .HasMaxLength(50);

            this.Property(t => t.ToolLocation)
                .HasMaxLength(5);

            this.Property(t => t.Description)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SelectCurrentProductionTool");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.MachineName).HasColumnName("MachineName");
            this.Property(t => t.TrackId).HasColumnName("TrackId");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.Expr1).HasColumnName("Expr1");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
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
            this.Property(t => t.RealToolId).HasColumnName("RealToolId");
            this.Property(t => t.Expr2).HasColumnName("Expr2");
            this.Property(t => t.ToolId).HasColumnName("ToolId");
            this.Property(t => t.UseNumber).HasColumnName("UseNumber");
            this.Property(t => t.Expr3).HasColumnName("Expr3");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Expr4).HasColumnName("Expr4");
            this.Property(t => t.Expr5).HasColumnName("Expr5");
            this.Property(t => t.Quota).HasColumnName("Quota");
            this.Property(t => t.ToolIndex).HasColumnName("ToolIndex");
            this.Property(t => t.ToolLocation).HasColumnName("ToolLocation");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
