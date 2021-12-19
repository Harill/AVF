using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionTesting
    {
        public ProductionTesting()
        {
            this.ProductionTestingDetails = new List<ProductionTestingDetail>();
        }

        public int ProductionTestingId { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public string Note { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual ICollection<ProductionTestingDetail> ProductionTestingDetails { get; set; }
    }
}
