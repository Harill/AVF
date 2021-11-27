using System;
using System.Linq;
using System.Collections.Generic;
using Vfi.Ui.Mvc.Vfi.Models.Production;

namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models
{

    public class ToolInventoryModel {
        private string _lotNumber;

        public ToolInventoryModel() {
            UnitPrice = 0;
            Early = 0;
            Import = 0;
            Export = 0;
            LotNumber = "";
            ProductionTools = new List<ProductionToolModel>();
        }

        public List<ProductionToolModel> ProductionTools { get; set; }

        public string ProductCodes {
            get {
                return ProductionTools.Any() ?
                    ProductionTools.Select(i => i.ProductCode + "(" + string.Format("{0:n0}", i.ProductOrder) + ")")
                    .Aggregate((i, j) => i + ", " + j)
                    : "";
                //var productCodes = "";
                //foreach (var productionToolModel in ProductionTools)
                //{
                //    if (productionToolModel.ProductOrder > 0)
                //        productCodes += productionToolModel.ProductCode + "(" + productionToolModel.ProductOrder + "), ";
                //}
                //return productCodes;
            }
        }

        public int MaterialTypeId { get; set; }
        public string MaterialTypeName { get; set; }
        public int ToolInvId { get; set; }
        public int ToolId { get; set; }
        public string ToolName { get; set; }
        public string ToolCode { get; set; }
        public string ToolFullCode { get; set; }
        public string ToolDesign { get; set; }
        public string ToolMaterial { get; set; }
        public string ToolProduction { get; set; }
        public double TotalQuantity { get; set; }
        public double Quantity { get; set; }
        public DateTime? ImportDate { get; set; }

        public string ImportDateString {
            get { return ImportDate != null ? ImportDate.Value.ToString("dd/MM/yyyy") : ""; }
        }

        public double FirstImportQuantity { get; set; }
        public DateTime? FirstUseDate { get; set; }

        public string FirstUseDateString {
            get { return FirstUseDate != null ? FirstUseDate.Value.ToString("dd/MM/yyyy") : ""; }
        }

        public DateTime? EndDate { get; set; }

        public string EndDateString {
            get { return EndDate != null ? EndDate.Value.ToString("dd/MM/yyyy") : ""; }
        }

        public string StoreCode { get; set; }

        public string LotNumber {
            get { return _lotNumber; }
            set { _lotNumber = value.Trim(); }
        }

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
            get { return TotalImport * UnitPrice; }
        }
        public double ImportMore { get; set; }
        public double ImportInternal { get; set; }
        public double TotalImport { get { return Import + ImportMore + ImportInternal; } }

        public double Export { get; set; }
        public double ExportPrice {
            get { return TotalExport * UnitPrice; }
        }
        public double ExportDestroy { get; set; }
        public double ExportInternal { get; set; }
        public double TotalExport { get { return Export + ExportDestroy + ExportInternal; } }

        public double Last {
            get { return Early + TotalImport - TotalExport; }
        }
        public double LastPrice {
            get { return Last * UnitPrice; }
        }

        public bool IsShow {
            get {
                return Early 
                    + Import + ImportMore + ImportInternal 
                    + Export + ExportInternal + ExportDestroy > 0;
            }
        }

        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int ToolTypeId { get; set; }

        public double Export3Month { get; set; }
    }

    public class GroupToolInventory {
        public GroupToolInventory() {
            List = new List<ReportToolInventory>();
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
        public double ImportInternal {
            get { return List.Sum(l => l.ImportInternal); }
        }
        public double ImportPrice {
            get { return List.Sum(l => l.ImportPrice); }
        }
        public double Export {
            get { return List.Sum(l => l.Export); }
        }
        public double ExportInternal {
            get { return List.Sum(l => l.ExportInternal); }
        }
        public double ExportPrice {
            get { return List.Sum(l => l.ExportPrice); }
        }
        public double Last {
            get { return List.Sum(l => l.Last); }
        }
        public double LastPrice {
            get { return List.Sum(l => l.LastPrice); }
        }
        public List<ReportToolInventory> List { get; set; }
        public string LastPeriodDateString { get; set; }
        public string ReportDateString { get; set; }
        public double Export3Month { get { return List.Sum(l => l.Export3Month); } }
    }

    public class ReportToolInventory {
        public ReportToolInventory() {
            Details = new List<ToolInventoryModel>();
            ProductionTools = new List<ProductionToolModel>();
        }

        public List<ProductionToolModel> ProductionTools { get; set; }
        public int MaterialTypeId { get; set; }
        public string MaterialTypeName { get; set; }
        public int ToolTypeId { get; set; }
        public int ToolId { get; set; }
        public string ToolName { get; set; }
        public string ToolCode { get; set; }
        public string ToolFullCode { get; set; }
        public string ToolDesign { get; set; }
        public string ToolMaterial { get; set; }
        public string ToolProduction { get; set; }
        public double TotalInv {
            get { return Details.Sum(l => l.TotalQuantity); }
        }
        public double Early {
            get { return Details.Sum(l => l.Early); }
        }
        public double EarlyPrice {
            get { return Details.Sum(l => l.EarlyPrice); }
        }
        public double Import {
            get { return Details.Sum(l => l.Import); }
        }
        public double ImportInternal {
            get { return Details.Sum(l => l.ImportInternal); }
        }
        public double ImportPrice {
            get { return Details.Sum(l => l.ImportPrice); }
        }
        public double Export {
            get { return Details.Sum(l => l.Export); }
        }
        public double ExportInternal {
            get { return Details.Sum(l => l.ExportInternal); }
        }
        public double ExportPrice {
            get { return Details.Sum(l => l.ExportPrice); }
        }
        public double Last {
            get { return Details.Sum(l => l.Last); }
        }
        public double LastPrice {
            get { return Details.Sum(l => l.LastPrice); }
        }
        public List<ToolInventoryModel> Details { get; set; }
        public string LastPeriodDateString { get; set; }
        public string ReportDateString { get; set; }
        public double Export3Month { get; set; }
    }
}