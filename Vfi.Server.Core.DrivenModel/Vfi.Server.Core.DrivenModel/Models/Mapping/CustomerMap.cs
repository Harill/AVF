using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vfi.Server.Core.DrivenModel.Models.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            HasKey(t => t.CustomerId);

            // Properties
            Property(t => t.CustomerCode)
                .HasMaxLength(50);

            Property(t => t.CustomerName)
                .HasMaxLength(255);

            Property(t => t.ShortName)
                .HasMaxLength(255);

            Property(t => t.CompanyName)
                .HasMaxLength(255);

            Property(t => t.ContactName)
                .HasMaxLength(255);

            Property(t => t.Address)
                .HasMaxLength(255);

            Property(t => t.Eaddress)
                .HasMaxLength(100);

            Property(t => t.Phone)
                .HasMaxLength(100);

            Property(t => t.Fax)
                .HasMaxLength(100);

            Property(t => t.Email)
                .HasMaxLength(100);

            Property(t => t.TaxCode)
                .HasMaxLength(50);

            Property(t => t.BankAccount)
                .HasMaxLength(50);

            Property(t => t.SpecialInfo)
                .HasMaxLength(255);

            Property(t => t.Note)
                .HasMaxLength(500);

            Property(t => t.ModifiedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Customer", "Sales");
            Property(t => t.CustomerId).HasColumnName("CustomerId");
            Property(t => t.CustomerTypeId).HasColumnName("CustomerTypeId");
            Property(t => t.CustomerCode).HasColumnName("CustomerCode");
            Property(t => t.CustomerName).HasColumnName("CustomerName");
            Property(t => t.ShortName).HasColumnName("ShortName");
            Property(t => t.CompanyName).HasColumnName("CompanyName");
            Property(t => t.ContactName).HasColumnName("ContactName");
            Property(t => t.Address).HasColumnName("Address");
            Property(t => t.Eaddress).HasColumnName("Eaddress");
            Property(t => t.Phone).HasColumnName("Phone");
            Property(t => t.Fax).HasColumnName("Fax");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.TaxCode).HasColumnName("TaxCode");
            Property(t => t.BankAccount).HasColumnName("BankAccount");
            Property(t => t.MaxCredit).HasColumnName("MaxCredit");
            Property(t => t.SpecialInfo).HasColumnName("SpecialInfo");
            Property(t => t.Note).HasColumnName("Note");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasOptional(t => t.CustomerType)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.CustomerTypeId);

        }
    }
}
