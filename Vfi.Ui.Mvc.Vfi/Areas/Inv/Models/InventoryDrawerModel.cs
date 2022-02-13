using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class InventoryDrawerModel {

        public int DrawerId { get; set; }
        public string DrawerCode { get { return RowName + ShelftName + "-" + ColumnName + AdditionName; } }
        public int ShelfId { get; set; }
        public string ShelftName { get; set; }
        public string ColumnName { get; set; }
        public string RowName { get; set; }
        public string AdditionName { get; set; }

        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }

        public int ReferenceId { get; set; }
        public string ReferenceCode { get; set; }

        public int ReferenceInvId { get; set; }
        public string ReferenceInvCode { get; set; }
        public string LotNumber { get; set; }
        public string OwnerName { get; set; }
        public double UnitWeight { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public int ClassifiedId { get; set; }
    }
}