using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class MethodMap : EntityTypeConfiguration<Method>
    {
        public MethodMap()
        {
            // Primary Key
            this.HasKey(t => t.MethodId);

            // Properties
            this.Property(t => t.MethodName)
                .IsRequired();

            this.Property(t => t.MethodName_EN)
                .IsRequired();

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Method", "Purchasing");
            this.Property(t => t.MethodId).HasColumnName("MethodId");
            this.Property(t => t.MethodTypeId).HasColumnName("MethodTypeId");
            this.Property(t => t.MethodName).HasColumnName("MethodName");
            this.Property(t => t.MethodName_EN).HasColumnName("MethodName_EN");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.SaleMethod).HasColumnName("SaleMethod");
            this.Property(t => t.BuyMethod).HasColumnName("BuyMethod");

            // Relationships
            this.HasOptional(t => t.MethodType)
                .WithMany(t => t.Methods)
                .HasForeignKey(d => d.MethodTypeId);

        }
    }
}
