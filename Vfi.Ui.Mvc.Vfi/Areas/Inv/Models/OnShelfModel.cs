using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class OnShelfModel {

        public int OnShelfId { get; set; }
        [DataType("_DateTemplate")]
        public DateTime OnDate { get; set; }

        public int DrawerId { get; set; }
        [DataType("_InventoryDrawerTemplate")]
        public string DrawerCode { get; set; }

        public int ReferenceId { get; set; }
        [DataType("_ItemBindingTemplate")]
        public string ReferenceCode { get; set; }

        public int ReferenceInvId { get; set; }
        [DataType("_ItemInventoryBindingTemplate")]
        public string ReferenceInvCode { get; set; }
        public string LotNumber { get; set; }
        public string OwnerName { get; set; }
        public double UnitWeight { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public int ClassifiedId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public bool Active { get; set; }
    }
}