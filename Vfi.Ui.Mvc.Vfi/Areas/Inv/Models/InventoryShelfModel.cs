using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class InventoryShelfModel {
        public int ShelfId { get; set; }
        public string ShelfName { get; set; }
        public int ClassifiedId { get; set; }
        [DataType("_MaterialClassifiedEditTemplate")]
        public string ClassifiedName { get; set; }
        public Nullable<int> WarehouseId { get; set; }
        [DataType("_WarehouseEditTemplate")]
        public string WarehouseName { get; set; }
        [DataType("NumberAsInt")]
        public int MaxColumn { get; set; }
        [DataType("NumberAsInt")]
        public int MaxRow { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public bool Active { get; set; }
    }
}