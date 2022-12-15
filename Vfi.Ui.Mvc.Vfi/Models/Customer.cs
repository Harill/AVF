using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Customer
    {
        public Customer()
        {
            this.ExportFormTP_KD = new List<ExportFormTP_KD>();
            this.Products = new List<Product>();
            this.CustomerAccessPermissions = new List<CustomerAccessPermission>();
            this.Invoices = new List<Invoice>();
            this.QuoteForms = new List<QuoteForm>();
            this.Orders = new List<Order>();
            this.TaxInvoices = new List<TaxInvoice>();
        }

        public int CustomerId { get; set; }
        public int CustomerTypeId { get; set; }
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
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int AreaId { get; set; }
        public int CustomerPayTypeId { get; set; }
        public bool UseForecast { get; set; }
        public int EmployeeId { get; set; }
        public Nullable<bool> IsMonitor { get; set; }
        public int ClassifiedId { get; set; }
        public System.DateTime StartDate { get; set; }
        public int State { get; set; }
        public bool IsNotRequireApproveOrder { get; set; }
        public bool IsWorkOrder { get; set; }
        public Nullable<int> ShippingMethodId { get; set; }
        public virtual ICollection<ExportFormTP_KD> ExportFormTP_KD { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ShipMethod ShipMethod { get; set; }
        public virtual Area Area { get; set; }
        public virtual CustomerClassified CustomerClassified { get; set; }
        public virtual CustomerType CustomerType { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<CustomerAccessPermission> CustomerAccessPermissions { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<QuoteForm> QuoteForms { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<TaxInvoice> TaxInvoices { get; set; }
    }
}
