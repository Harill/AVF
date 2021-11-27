using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class FunctionMap : EntityTypeConfiguration<Function>
    {
        public FunctionMap()
        {
            // Primary Key
            HasKey(t => t.FunctionId);

            // Properties
            Property(t => t.FunctionCode)
                .HasMaxLength(50);

            Property(t => t.FunctionName)
                .HasMaxLength(150);

            Property(t => t.Description)
                .HasMaxLength(150);

            // Table & Column Mappings
            ToTable("Function", "System");
            Property(t => t.FunctionId).HasColumnName("FunctionId");
            Property(t => t.ParentId).HasColumnName("ParentId");
            Property(t => t.FunctionCode).HasColumnName("FunctionCode");
            Property(t => t.FunctionName).HasColumnName("FunctionName");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.IDx).HasColumnName("IDx");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasOptional(t => t.Function2)
                .WithMany(t => t.Function1)
                .HasForeignKey(d => d.ParentId);

        }
    }
}
