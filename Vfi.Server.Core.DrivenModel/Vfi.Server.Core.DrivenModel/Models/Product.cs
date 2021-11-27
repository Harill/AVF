using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class Product
    {
        public Product()
        {
            MachineAppraisals = new List<MachineAppraisal>();
            ProductInventories = new List<ProductInventory>();
            ProductInventoryPeriods = new List<ProductInventoryPeriod>();
            StockOrderDetails = new List<StockOrderDetail>();
            TransactionDetails = new List<TransactionDetail>();
            InvoiceDetails = new List<InvoiceDetail>();
            SalesOrderDetails = new List<SalesOrderDetail>();
        }

        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int MaterialId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string DesignNo { get; set; }
        public Nullable<double> Diameter { get; set; }
        public Nullable<double> Length { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<double> ForecastsQuality { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<MachineAppraisal> MachineAppraisals { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<ProductInventoryPeriod> ProductInventoryPeriods { get; set; }
        public virtual ICollection<StockOrderDetail> StockOrderDetails { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
        public virtual Material Material { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
