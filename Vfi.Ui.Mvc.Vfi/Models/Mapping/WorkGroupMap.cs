using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class WorkGroupMap : EntityTypeConfiguration<WorkGroup>
    {
        public WorkGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkGroupId);

            // Properties
            this.Property(t => t.WorkGroupCode)
                .HasMaxLength(50);

            this.Property(t => t.WorkGroupName)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(50);

            this.Property(t => t.Theme)
                .HasMaxLength(50);

            this.Property(t => t.BackgroundImage)
                .HasMaxLength(50);

            this.Property(t => t.LogoImage)
                .HasMaxLength(50);

            this.Property(t => t.PageTitleColor)
                .HasMaxLength(50);

            this.Property(t => t.CompanyName)
                .HasMaxLength(50);

            this.Property(t => t.CompanyFullName)
                .HasMaxLength(50);

            this.Property(t => t.CompanyShortName)
                .HasMaxLength(50);

            this.Property(t => t.TelNumber)
                .HasMaxLength(50);

            this.Property(t => t.FaxNumber)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Website)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WorkGroup", "System");
            this.Property(t => t.WorkGroupId).HasColumnName("WorkGroupId");
            this.Property(t => t.WorkGroupCode).HasColumnName("WorkGroupCode");
            this.Property(t => t.WorkGroupName).HasColumnName("WorkGroupName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Theme).HasColumnName("Theme");
            this.Property(t => t.BackgroundImage).HasColumnName("BackgroundImage");
            this.Property(t => t.LogoImage).HasColumnName("LogoImage");
            this.Property(t => t.ImagePath).HasColumnName("ImagePath");
            this.Property(t => t.PageTitleColor).HasColumnName("PageTitleColor");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.CompanyFullName).HasColumnName("CompanyFullName");
            this.Property(t => t.CompanyShortName).HasColumnName("CompanyShortName");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.TelNumber).HasColumnName("TelNumber");
            this.Property(t => t.FaxNumber).HasColumnName("FaxNumber");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Website).HasColumnName("Website");
        }
    }
}
