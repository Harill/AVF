using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class WorkpieceMaterialModel
    {
        public string Group { get; set; }
        public string MaterialType { get; set; }
        public double InventoryStartMonth { get; set; }
        public double EarlyInventory { get; set; }
        public double LastInventory { get; set; }
        public double Import { get; set; }
        public double Export { get; set; }
        public double TotalImport { get; set; }
        public double TotalExport { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportDateString { get; set; }
    }

    public class WorkpieceMaterialDetailModel
    {
        public int MaterialInvId { get; set; }
        public string MaterialCode { get; set; }
        public string VendorCode { get; set; }
        public string LotNumber { get; set; }
        public int ProductId { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public double MaterialWeight { get; set; }
        public double MaterialUse { get; set; }

        public string ProductCode { get; set; }
        public double ProductWeight { get; set; }
        public double Production { get; set; }

        public double Workpiece { get; set; }
    }
}