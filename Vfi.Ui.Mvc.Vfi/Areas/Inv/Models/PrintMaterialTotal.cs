using System;
using System.Collections.Generic;
using System.Linq;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class PrintGroupMaterialTotal
    {public PrintGroupMaterialTotal()
    {
        List = new List<PrintGroupMaterialDesign>();
    }
        public int MaterialTyleId { get; set; }
        public string GroupName { get; set; }
        public List<PrintGroupMaterialDesign> List { get; set; }


        public double Import { get { return List.Sum(d => d.Import); } }
        public double ImportKg { get { return List.Sum(d => d.ImportKg); } }
        public double ImportPrice { get { return List.Sum(d => d.ImportPrice); } }
        public double Export { get { return List.Sum(d => d.Export); } }
        public double ExportKg { get { return List.Sum(d => d.ExportKg); } }
        public double ExportPrice { get { return List.Sum(d => d.ExportPrice); } }
        public double ExportDestroyed { get { return List.Sum(d => d.ExportDestroyed); } }
        public double ExportDestroyedKg { get { return List.Sum(d => d.ExportDestroyedKg); } }
        public double EarlyQuantity { get { return List.Sum(d => d.EarlyQuantity); } }
        public double EarlyQuantityKg { get { return List.Sum(d => d.EarlyQuantityKg); } }
        public double EarlyPrice { get { return List.Sum(d => d.EarlyPrice); } }
        public double LastQuantity { get { return List.Sum(d => d.LastQuantity); } }
        public double LastQuantityKg { get { return List.Sum(d => d.LastQuantityKg); } }
        public double LastPrice { get { return List.Sum(d => d.LastPrice); } }
        public double MaterialOnMachine { get { return List.Sum(d => d.MaterialOnMachine); } }
        public DateTime ReportDate { get; set; }
        public DateTime LastPeriodDate { get; set; }
        public string LastPeriodDateString { get; set; }
    }
  
    public class PrintGroupMaterialDesign
    {
        public PrintGroupMaterialDesign()
        {
            Details = new List<PrintMaterialTotal>();
        }
        public int MaterialTypeId { get; set; }
        public string MaterialTypeCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialCode { get; set; }
        public string Shape { get; set; }
        public double OutDiameter { get; set; }
        public double InDiameter { get; set; }
        public string DiameterType { get; set; }

        public double Import { get { return Details.Sum(d=> d.Import); } }
        public double ImportKg { get { return Details.Sum(d => d.ImportKg); } }
        public double ImportPrice { get { return Details.Sum(d => d.ImportPrice); } }
        public double Export { get { return Details.Sum(d => d.Export); } }
        public double ExportKg { get { return Details.Sum(d => d.ExportKg); } }
        public double ExportPrice { get { return Details.Sum(d => d.ExportPrice); } }
        public double ExportDestroyed { get { return Details.Sum(d => d.ExportDestroyed); } }
        public double ExportDestroyedKg { get { return Details.Sum(d => d.ExportDestroyedKg); } }
        public double EarlyQuantity { get { return Details.Sum(d => d.EarlyQuantity); } }
        public double EarlyQuantityKg { get { return Details.Sum(d => d.EarlyQuantityKg); } }
        public double EarlyPrice { get { return Details.Sum(d => d.EarlyPrice); } }
        public double LastQuantity { get { return Details.Sum(d => d.LastQuantity); } }
        public string LastQuantityString { get { return Details.Count > 1 ? string.Format("{0:n2}", LastQuantityKg) : ""; } }
        public double LastQuantityKg { get { return Details.Sum(d => d.LastQuantityKg); } }
        public double LastPrice { get { return Details.Sum(d => d.LastPrice); } }
        public double MaterialOnMachine { get { return Details.Sum(d => d.MaterialOnMachine); } }
        public List<PrintMaterialTotal> Details { get; set; }
        public bool Show { get { return Details.Any(); } }
    }


    public class PrintMaterialTotal
    {
        public PrintMaterialTotal()
        {
            Import = 0;
            Export = 0;
            EarlyQuantity = 0;
            LastQuantity = 0;
            MaterialUnitWeight = 0;
            MaterialUnitPrice = 0;
            ExportDestroyed = 0;
        }

        public int MaterialTypeId { get; set; }
        public string MaterialTypeCode { get; set; }
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public string MaterialCode { get; set; }
        public string Shape { get; set; }
        public double OutDiameter { get; set; }
        public double InDiameter { get; set; }
        public double Length { get; set; }
        public string DiameterType { get; set; }
        //
        public int MaterialInvId { get; set; }
        public string MaterialLot { get; set; }
        public double MaterialUnitWeight { get; set; }
        public double MaterialUnitPrice { get; set; }
        //
        public double Import { get; set; }
        public double ImportKg
        {
            get { return Import*MaterialUnitWeight; }
        }
        public double SendBack { get; set; }

        public double ImportPrice
        {
            get { return ImportKg * MaterialUnitPrice; }
        }
        public double Export { get; set; }
        public double ExportKg
        {
            get { return Export * MaterialUnitWeight; }
        }
        public double ExportPrice
        {
            get { return ExportKg * MaterialUnitPrice; }
        }
        public double ExportDestroyed { get; set; }
        public double ExportDestroyedKg
        {
            get { return ExportDestroyed * MaterialUnitWeight; }
        }
        public double ExportDestroyedOnMachine { get; set; }
        public double EarlyQuantity { get; set; }
        public double EarlyQuantityKg
        {
            get { return EarlyQuantity * MaterialUnitWeight; }
        }
        public double EarlyPrice
        {
            get { return EarlyQuantityKg * MaterialUnitPrice; }
        }
        public double LastQuantity { get; set; }

        public double LastQuantityCheck
        {
            get { return EarlyQuantity + Import - Export - ExportDestroyed - ExportDestroyedOnMachine - LastQuantity; }
        }

        public double LastQuantityKg
        {
            get { return LastQuantity * MaterialUnitWeight; }
        }
        public double LastPrice
        {
            get { return LastQuantityKg * MaterialUnitPrice; }
        }
        public double MaterialOnMachine { get; set; }

        public Boolean Print
        {
            get
            {
                return Import + Export + ExportDestroyed + ExportDestroyedOnMachine + SendBack + EarlyQuantity +
                       LastQuantity > 0;
            }
        }

        public int VendorId { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public bool Show { get; set; }
        public string ImportDateString { get; set; }
        public string FirstImport { get; set; }
        public string FirstImportKg { get; set; }
        public string FirstUseDateString { get; set; }
        public string EndUseDateString { get; set; }
        public string StoreCode { get; set; }
    }
    
}