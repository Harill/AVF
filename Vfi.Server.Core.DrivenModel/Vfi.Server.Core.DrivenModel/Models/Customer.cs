using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Products = new List<Product>();
            Invoices = new List<Invoice>();
            SalesOrders = new List<SalesOrder>();
        }

        public int CustomerId { get; set; }
        public Nullable<int> CustomerTypeId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string ShortName { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string Eaddress { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string TaxCode { get; set; }
        public string BankAccount { get; set; }
        public Nullable<double> MaxCredit { get; set; }
        public string SpecialInfo { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual CustomerType CustomerType { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
