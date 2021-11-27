using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionDefect
    {
        public ProductionDefect()
        {
            this.DefectInventories = new List<DefectInventory>();
            this.DefectTransactionDetails = new List<DefectTransactionDetail>();
            this.ProductInventories = new List<ProductInventory>();
            this.TransactionDetails = new List<TransactionDetail>();
        }

        public int DefectId { get; set; }
        public string DefectName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int ProductId { get; set; }
        public int DefectTypeId { get; set; }
        public string DefectCode { get; set; }
        public Nullable<int> DefaultRemedyId { get; set; }
        public virtual ICollection<DefectInventory> DefectInventories { get; set; }
        public virtual ICollection<DefectTransactionDetail> DefectTransactionDetails { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductionDefectRemedy ProductionDefectRemedy { get; set; }
        public virtual ProductionDefectType ProductionDefectType { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
