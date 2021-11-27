using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class ToolOrderMap : EntityTypeConfiguration<ToolOrder>
    {
        public ToolOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.ToolOrderId);

            // Properties
            this.Property(t => t.TransactionCode)
                .HasMaxLength(50);

            this.Property(t => t.EoI)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CreatedUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ToolOrder", "Factory");
            this.Property(t => t.ToolOrderId).HasColumnName("ToolOrderId");
            this.Property(t => t.TransactionCode).HasColumnName("TransactionCode");
            this.Property(t => t.EoI).HasColumnName("EoI");
            this.Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.IsApprove).HasColumnName("IsApprove");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
