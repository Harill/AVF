using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class TrackUpMachineMap : EntityTypeConfiguration<TrackUpMachine>
    {
        public TrackUpMachineMap()
        {
            // Primary Key
            this.HasKey(t => t.TrackId);

            // Properties
            this.Property(t => t.Phase)
                .HasMaxLength(50);

            this.Property(t => t.DeliveryEmployee)
                .HasMaxLength(50);

            this.Property(t => t.ReceiveEmployee)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TrackUpMachine", "Factory");
            this.Property(t => t.TrackId).HasColumnName("TrackId");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
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

            // Relationships
            this.HasRequired(t => t.Machine)
                .WithMany(t => t.TrackUpMachines)
                .HasForeignKey(d => d.MachineId);
            this.HasOptional(t => t.Material)
                .WithMany(t => t.TrackUpMachines)
                .HasForeignKey(d => d.MaterialId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.TrackUpMachines)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
