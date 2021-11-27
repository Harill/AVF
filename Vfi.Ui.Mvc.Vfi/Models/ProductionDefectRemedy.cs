using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionDefectRemedy
    {
        public ProductionDefectRemedy()
        {
            this.DefectTransactionDetails = new List<DefectTransactionDetail>();
            this.ProductionDefects = new List<ProductionDefect>();
        }

        public int RemedyId { get; set; }
        public string RemedyCode { get; set; }
        public string RemedyName { get; set; }
        public string Description { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public bool Active { get; set; }
        public Nullable<int> ProcessWarehouseId { get; set; }
        public virtual ICollection<DefectTransactionDetail> DefectTransactionDetails { get; set; }
        public virtual ICollection<ProductionDefect> ProductionDefects { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
