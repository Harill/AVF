using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ErrorCauseFormMap : EntityTypeConfiguration<ErrorCauseForm>
    {
        public ErrorCauseFormMap()
        {
            // Primary Key
            this.HasKey(t => t.ErrorCauseId);

            // Properties
            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            this.Property(t => t.StateCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ErrorCauseForm", "Factory");
            this.Property(t => t.ErrorCauseId).HasColumnName("ErrorCauseId");
            this.Property(t => t.StateId).HasColumnName("StateId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.StateCode).HasColumnName("StateCode");
        }
    }
}
