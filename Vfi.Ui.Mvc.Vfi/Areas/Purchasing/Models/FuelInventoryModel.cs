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
        public double ImportPrice {
            get { return Import * UnitPrice; }
        }
        public double ImportMore { get; set; }
        public double ImportInternal { get; set; }
        public double TotalImport { get { return Import + ImportMore + ImportInternal; } }
        public double TotalImportPrice {
            get { return TotalImport * UnitPrice; }
        }

        public double Export { get; set; }
        public double ExportPrice {
            get { return Export * UnitPrice; }
        }
        public double ExportDestroy { get; set; }
        public double ExportDestroyPrice {
            get { return ExportDestroy * UnitPrice; }
        }
        public double ExportInternal { get; set; }
        public double ExportInternalPrice {
            get { return ExportInternal * UnitPrice; }
        }
        public double TotalExport { get { return Export + ExportDestroy + ExportInternal; } }
        public double TotalExportPrice {
            get { return TotalExport * UnitPrice; }
        }
        
        public double Last {
            get { return Early + TotalImport - TotalExport; }
        }
        public double LastPrice {
            get { return Last * UnitPrice; }
        }

        public bool IsShow {
            get {
                return Early + TotalImport + TotalExport != 0;
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
        public double Early {
            get { return List.Sum(l => l.Early); }
        }
        public double EarlyPrice {
            get { return List.Sum(l => l.EarlyPrice); }
        }

        public double Import {
            get { return List.Sum(l => l.Import); }
        }
        public double ImportPrice {
            get { return List.Sum(l => l.ImportPrice); }
        }
        public double ImportMore {
            get { return List.Sum(l => l.ImportMore); }
        }
        public double ImportInternal {
            get { return List.Sum(l => l.ImportInternal); }
        }
        public double TotalImport {
            get { return List.Sum(l => l.TotalImport); }
        }
        public double TotalImportPrice {
            get { return List.Sum(l => l.TotalImportPrice); }
        }

        public double Export {
            get { return List.Sum(l => l.Export); }
        }
        public double ExportPrice {
            get { return List.Sum(l => l.ExportPrice); }
        }
        public double ExportDestroy {
            get { return List.Sum(l => l.ExportDestroy); }
        }
        public double ExportDestroyPrice {
            get { return List.Sum(l => l.ExportDestroyPrice); }
        }
        public double ExportInternal {
            get { return List.Sum(l => l.ExportInternal); }
        }
        public double ExportInternalPrice {
            get { return List.Sum(l => l.ExportInternalPrice); }
        }
        public double TotalExport {
            get { return List.Sum(l => l.TotalExport); }
        }
        public double TotalExportPrice {
            get { return List.Sum(l => l.TotalExportPrice); }
        }

        public double Last {
            get { return List.Sum(l => l.Last); }
        }
        public double LastPrice {
            get { return List.Sum(l => l.LastPrice); }
        }
        public List<FuelInventoryModel> List { get; set; }
        public string LastPeriodDateString { get; set; }
        public string ReportDateString { get; set; }
    }
}