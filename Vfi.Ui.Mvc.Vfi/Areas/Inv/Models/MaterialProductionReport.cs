using System;
using System.Collections.Generic;
using System.Linq;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class MaterialProductionReport
    {
        public MaterialProductionReport()
        {
            EarlyQuantity = 0;
            Import = 0;
            Export = 0;
            LastQuantity = 0;
            FromDate = DateTime.Now;
            ToDate = DateTime.Now;
            ProductInv = 0;
            ProductForecast = 0;
            MaterialUse = 0;
        }
        public MaterialProductionReport(MaterialProductionReport entity)
        {
            FromDate = entity.FromDate;
            FromDateString = entity.FromDateString;
            ToDate = entity.ToDate;
            ToDateString = entity.ToDateString;
        //
            MaterialTypeId = entity.MaterialTypeId;
            MaterialTypeCode = entity.MaterialTypeCode;
            MaterialTypeName = entity.MaterialTypeName;
        //
            MaterialId = entity.MaterialId;
            MaterialName = entity.MaterialName;
            MaterialCode = entity.MaterialCode;
            Shape = entity.Shape;
            OutDiameter = entity.OutDiameter;
            InDiameter = entity.InDiameter;
            DiameterType = entity.DiameterType;
        //
            EarlyQuantity = entity.EarlyQuantity;
            Import = entity.Import;
                Export = entity.Export;
            LastQuantity = entity.LastQuantity;
            //AvgQuantity = entity.AvgQuantity;

            PoQuantity = entity.PoQuantity;
            PoDate = entity.PoDate;
            ProductExport = entity.ProductExport;
            ProductInv = entity.ProductInv;
            ProductForecast = entity.ProductForecast;
            OrderForecast = entity.OrderForecast;
            ProductCode = entity.ProductCode;
            ProductionWeight = entity.ProductionWeight;
            Productivity = entity.Productivity;
            AvgExport = entity.AvgExport;
            ProductId = entity.ProductId;
            OrderQuantity = entity.OrderQuantity;
            AvgForecast = entity.AvgForecast;
            AvgOrder = entity.AvgOrder;
            MaterialUse = entity.MaterialUse;
        }
        public DateTime FromDate { get; set; }
        public string FromDateString { get; set; }
        public DateTime ToDate { get; set; }
        public string ToDateString { get; set; }
        //
        public int MaterialTypeId { get; set; }
        public string MaterialTypeCode { get; set; }
        public string MaterialTypeName { get; set; }
        //
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public string MaterialCode { get; set; }
        public string Shape { get; set; }
        public double OutDiameter { get; set; }
        public double InDiameter { get; set; }
        public string DiameterType { get; set; }
        //
        public double EarlyQuantity { get; set; }
        public double Import { get; set; }
        public double Export { get; set; }
        public double LastQuantity { get; set; }
        //public double AvgQuantity { get; set; }
        public double AvgExport { get; set; }

        public double PoQuantity { get; set; }
        public string PoDate { get; set; }

        public int ExportDay
        {
            get
            {
                return ProductionPlan * ProductionWeight > 0
                    ? MyUtilities.Function.RoundUp(LastQuantity / (ProductionPlan * ProductionWeight/1000))
                    : 0;
            }
        }

        public string ExportDateString
        {
            get
            {
                return ExportDay > 0
                    ? ExportDay + MyUtilities.Function.ToDate(ToDate, ExportDay).ToString("(dd/MM)")
                    : "";
            }
        }

        //
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double ProductExport { get; set; }
        public double ProductInv { get; set; }
        public double ProductForecast { get; set; }
        public double OrderForecast { get; set; }
        public double AvgForecast { get; set; }
        public double AvgOrder { get; set; }
        public double OrderQuantity { get; set; }

        public double RequireInv
        {
            get
            {
                return ProductForecast > 0
                    ? ProductInv > ProductForecast
                        ? 0
                        : ProductForecast - ProductInv
                    : OrderForecast > 0
                        ? ProductInv > OrderForecast
                            ? 0
                            : OrderForecast - ProductInv
                        : ProductInv > OrderQuantity
                            ? 0
                            : OrderQuantity - ProductInv;
            }
        }
        public double RequireInvKg
        {
            get { return RequireInv * ProductionWeight / 1000; }
        }
        public double ProductionWeight { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public double MaterialUse { get; set; }
        public double MaterialUseKg
        {
            get
            {
                return MaterialUse * ProductionWeight;
            }
        }
        public double Productivity { get; set; }
        //
        public double ProductionPlan
        {
            get {
                return MyUtilities.Product.GetProductionRateInFactoryDayTime(Productivity);
                //return Productivity > 0 ? MyUtilities.Product.Second20h / Productivity : 0;
            }
        }

        public double ProductionPlanKg
        {
            get { return ProductionPlan * ProductionWeight / 1000; }
        }

        public int ProductionPlanDay
        {
            get
            {
                return ProductionPlan > 0
                    ? MyUtilities.Function.RoundUp(RequireInv / (ProductionPlan))
                    : 0;
            }
        }

        public string ProductionPlanDateString
        {
            get
            {
                return ProductionPlanDay > 0
                    ? ProductionPlanDay+ MyUtilities.Function.ToDate(ToDate, ProductionPlanDay).ToString("(dd/MM)")
                    : "";
            }
        }
        //
        public double ProductionQuantityByTrack { get; set; }
        public double ProductionQuantity { get; set; }
        public double ProductionQuantityKg { get { return ProductionQuantity * ProductionWeight / 1000; } }
        public double MaterialUseKgByTrack { get; set; }
        public int ProductionDay
        {
            get { return ProductionQuantity > 0 ? MyUtilities.Function.RoundUp(RequireInv / ProductionQuantity) : 0; }
        }
        public string ProductionDateString
        {
            get
            {
                return ProductionDay > 0
                    ? ProductionDay + MyUtilities.Function.ToDate(ToDate, ProductionDay).ToString("(dd/MM)")
                    : "";
            }
        }

        public bool Check
        {
            get { return ProductForecast + OrderForecast + OrderQuantity > 0; }
        }
    }

    public class MaterialGroupProductionReport
    {
        public MaterialGroupProductionReport()
        {
            FromDate = DateTime.Now;
            ToDate = DateTime.Now;
            Productions = new List<MaterialProductionReport>();
        }
        public List<MaterialProductionReport> Productions { get; set; }
        public DateTime FromDate { get; set; }
        public string FromDateString { get; set; }
        public DateTime ToDate { get; set; }
        public string ToDateString { get; set; }
        //
        public int MaterialTypeId { get; set; }
        public string MaterialTypeCode { get; set; }
        public string MaterialTypeName { get; set; }
        //
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public string MaterialCode { get; set; }
        public string Shape { get; set; }
        public double OutDiameter { get; set; }
        public double InDiameter { get; set; }
        public string DiameterType { get; set; }
        public double ExportDay
        {
            get { return Productions.Any() ? Productions.FirstOrDefault().ExportDay : 0; }
        }
        public string ExportDateString
        {
            get { return Productions.Any() ? Productions.FirstOrDefault().ExportDateString : ""; }
        }
        //
        public double EarlyQuantity
        {
            get { return Productions.Any() ? Productions.FirstOrDefault().EarlyQuantity : 0; }
        }

        public double Import
        {
            get { return Productions.Any() ? Productions.FirstOrDefault().Import : 0; }
        }

        public double Export
        {
            get { return Productions.Any() ? Productions.FirstOrDefault().Export : 0; }
        }
        public double LastQuantity
        {
            get { return Productions.Any() ? Productions.FirstOrDefault().LastQuantity : 0; }
        }
        public double PoQuantity
        {
            get { return Productions.Any() ? Productions.FirstOrDefault().PoQuantity : 0; }
        }
        public string PoDate
        {
            get { return Productions.Any() ? Productions.FirstOrDefault().PoDate : ""; }
        }
    }
}