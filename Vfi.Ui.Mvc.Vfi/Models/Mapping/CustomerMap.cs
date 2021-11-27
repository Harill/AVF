using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Ui.Mvc.Vfi.Models.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerId);

            // Properties
            this.Property(t => t.CustomerCode)
                .HasMaxLength(50);

            this.Property(t => t.CustomerName)
                .HasMaxLength(255);

            this.Property(t => t.ShortName)
                .HasMaxLength(255);

            this.Property(t => t.CompanyName)
                .HasMaxLength(255);

            this.Property(t => t.ContactName)
                .HasMaxLength(255);

            this.Property(t => t.Address)
                .HasMaxLength(255);

            this.Property(t => t.Eaddress)
                .HasMaxLength(255);

            this.Property(t => t.Phone)
                .HasMaxLength(100);

            this.Property(t => t.Fax)
                .HasMaxLength(100);

            this.Property(t => t.Email)
                .HasMaxLength(100);

            this.Property(t => t.TaxCode)
                .HasMaxLength(50);

            this.Property(t => t.BankAccount)
                .HasMaxLength(50);

            this.Property(t => t.SpecialInfo)
                .HasMaxLength(255);

            this.Property(t => t.Note)
                .HasMaxLength(500);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Customer", "Sales");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.CustomerTypeId).HasColumnName("CustomerTypeId");
            this.Property(t => t.CustomerCode).HasColumnName("CustomerCode");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.ShortName).HasColumnName("ShortName");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Eaddress).HasColumnName("Eaddress");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.TaxCode).HasColumnName("TaxCode");
            this.Property(t => t.BankAccount).HasColumnName("BankAccount");
            this.Property(t => t.MaxCredit).HasColumnName("MaxCredit");
            this.Property(t => t.SpecialInfo).HasColumnName("SpecialInfo");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.AreaId).HasColumnName("AreaId");
            this.Property(t => t.CustomerPayTypeId).HasColumnName("CustomerPayTypeId");
            this.Property(t => t.UseForecast).HasColumnName("UseForecast");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.IsMonitor).HasColumnName("IsMonitor");
            this.Property(t => t.ClassifiedId).HasColumnName("ClassifiedId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.State).HasColumnName("State");

            // Relationships
            this.HasRequired(t => t.Area)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.AreaId);
            this.HasRequired(t => t.CustomerClassified)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.ClassifiedId);
            this.HasRequired(t => t.CustomerType)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.CustomerTypeId);
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.EmployeeId);

        }
    }
}
