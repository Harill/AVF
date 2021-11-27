using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models
{
    public class FuelInventoryModel
    {
        public int FuelInvId { get; set; }
        public int FuelId { get; set; }
        public string FuelName { get; set; }
        public string FuelCode { get; set; }
        public string FuelDesignNo { get; set; }

        public string FuelFullCode { get; set; }

        public double TotalQuantity { get; set; }
        public double Quantity { get; set; }
        public double FirstImportQuantity { get; set; }
        public string LotNumber { get; set; }
        public string UnitMeasure { get; set; }
        public double UnitPrice { get; set; }
        public int VendorId { get; set; }
        public string VendorCode { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime CreateDate { get; set; }

        public double Early { get; set; }

        public double EarlyPrice {
            get { return Early * UnitPrice; }
        }

        public double Import { get; set; }
        public double ImportMore { get; set; }

        public double ImportPrice {
            get { return Import * UnitPrice; }
        }

        public double Export { get; set; }
        public double ExportDestroy { get; set; }

        public double ExportPrice {
            get { return Export * UnitPrice; }
        }

        public double Last {
            get { return Early + Import - Export; }
        }

        public double LastPrice {
            get { return Last * UnitPrice; }
        }
        public bool IsShow {
            get {
                return Early + Import + ImportMore + Export + ExportDestroy > 0;
            }
        }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
    }

    public class GroupFuelInventory {
        public GroupFuelInventory() {
            List = new List<FuelInventoryModel>();
        }
        public int MaterialTypeId { get; set; }
        public string MaterialTypeName { get; set; }
        public string GroupName { get; set; }
        public double TotalInv { get; set; }
        public double TotalEarly {
            get { return List.Sum(l => l.Early); }
        }

        public double TotalEarlyPrice {
            get { return List.Sum(l => l.EarlyPrice); }
        }
        public double TotalImport {
            get { return List.Sum(l => l.Import); }
        }
        public double TotalImportPrice {
            get { return List.Sum(l => l.ImportPrice); }
        }
        public double TotalExport {
            get { return List.Sum(l => l.Export); }
        }
        public double TotalExportPrice {
            get { return List.Sum(l => l.ExportPrice); }
        }
        public double TotalLast {
            get { return List.Sum(l => l.Last); }
        }
        public double TotalLastPrice {
            get { return List.Sum(l => l.LastPrice); }
        }
        public List<FuelInventoryModel> List { get; set; }
        public string LastPeriodDateString { get; set; }
        public string ReportDateString { get; set; }
    }
}