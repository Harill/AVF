using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production {
    public class WarehousePermissionNewModel {
        public int WarehousePermissionId { get; set; }
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public int UserId { get; set; }
        public bool Import { get; set; }
        public bool ImportReadOnly { get; set; }
        public bool Rotate { get; set; }
        public bool OrderProgress { get; set; }
        public bool MainProgress { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}