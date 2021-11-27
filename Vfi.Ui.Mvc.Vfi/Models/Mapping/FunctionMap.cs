using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class FunctionMap : EntityTypeConfiguration<Function>
    {
        public FunctionMap()
        {
            // Primary Key
            this.HasKey(t => t.FunctionId);

            // Properties
            this.Property(t => t.FunctionCode)
                .HasMaxLength(50);

            this.Property(t => t.FunctionName)
                .HasMaxLength(150);

            this.Property(t => t.Description)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Function", "System");
            this.Property(t => t.FunctionId).HasColumnName("FunctionId");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.FunctionCode).HasColumnName("FunctionCode");
            this.Property(t => t.FunctionName).HasColumnName("FunctionName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.IDx).HasColumnName("IDx");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.Function2)
                .WithMany(t => t.Function1)
                .HasForeignKey(d => d.ParentId);

        }
    }
}
