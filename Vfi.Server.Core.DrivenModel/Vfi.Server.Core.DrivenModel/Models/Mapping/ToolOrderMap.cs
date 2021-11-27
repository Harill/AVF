using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class ToolOrderMap : EntityTypeConfiguration<ToolOrder>
    {
        public ToolOrderMap()
        {
            // Primary Key
            HasKey(t => t.ToolOrderId);

            // Properties
            Property(t => t.TransactionCode)
                .HasMaxLength(50);

            Property(t => t.EoI)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            Property(t => t.CreatedUser)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ToolOrder", "Factory");
            Property(t => t.ToolOrderId).HasColumnName("ToolOrderId");
            Property(t => t.TransactionCode).HasColumnName("TransactionCode");
            Property(t => t.EoI).HasColumnName("EoI");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.Status).HasColumnName("Status");
            Property(t => t.IsApprove).HasColumnName("IsApprove");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
