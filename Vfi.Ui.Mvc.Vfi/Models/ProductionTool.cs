using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionTool
    {
        public int RealToolId { get; set; }
        public int ProductId { get; set; }
        public int ToolId { get; set; }
        public int UseNumber { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public double Quota { get; set; }
        public Nullable<int> ToolIndex { get; set; }
        public string ToolLocation { get; set; }
        public string Description { get; set; }
        public int NamingToolId { get; set; }
        public Nullable<int> ProcessWarehouseId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Tool Tool { get; set; }
        public virtual Tool Tool1 { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
