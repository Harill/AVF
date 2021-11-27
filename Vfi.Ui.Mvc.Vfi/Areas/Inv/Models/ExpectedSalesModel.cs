using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ExpectedSalesModel
    {
        public ExpectedSalesModel()
        {
            //ForeCastDate = new DateTime();
        }
        public int ForecastId { get; set; }
        public int Index { get; set; }
        public int MonthCount { get; set; }
        public string MonthOrder { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        [DataType("_ProductEditTemplate")]
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductCustomerCode { get; set; }
        public double FinishInventory { get; set; }
        public double ProductTotalInventory { get; set; }
        public double AvgOrderQuantity { get; set; }
        [DataType("Number0")]
        public double ExpectedSalesQuantity { get; set; }
        [DataType("NumberAsFactor")]
        public double ProductionFactor { get; set; }
        public double ForecastProduction { get; set; }
        public double InvQuantityNeed { get; set; }
        public double InvQuantityNeedProduction { get; set; }
        [DataType("_DateTemplate2")]
        public DateTime? ForeCastDate { get; set; }
        public DateTime? DateNeedProduction { get; set; }
        //public string DateNeedProductionString { get; set; }
        public double InvQuantityNeedProcessing { get; set; }
        public DateTime? DateNeedProcessing { get; set; }
        //public string DateNeedProcessingString { get; set; }
        [DataType("Number")]
        public double ForeCastNext2Month { get; set; }
        [DataType("Number")]
        public double ForeCastNext3Month { get; set; }
        public double MaxOrderQuantityInMonth { get; set; }
        public double OrderQuantityInYear { get; set; }
        public bool IsSelling { get; set; }
        public bool Show { get; set; }
        [DataType("NumberAsFactor")]
        public double SaleFactor { get; set; }
        public double LastSaleFactor { get; set; }
        public double LastMonthSaleFactor { get; set; }
        public DateTime NewUpdateSaleFactor { get; set; }
        public DateTime LastUpdateSaleFactor { get; set; }
        public DateTime LastMonthUpdateSaleFactor { get; set; }
        public int SalesAlarmColor { get; set; }
        public int InventoryAlarmColor { get; set; }
        [DataType("NumberAsShort")]
        public int DayNeedProcessing { get; set; }

        [DataType("NumberAll")]
        public double DiffRequestInv { get; set; }
    }
    public class ExpectedSalesGroupModel
    {
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public List<ExpectedSalesModel> List { get; set; }
        public int ProductCount { get; set; }
        public double AvgOrderQuantity { get; set; }
        public double ExpectedSalesQuantity { get; set; }
        public double ForecastProduction { get; set; }
        public double ForeCastNext2Month { get; set; }
        public double ForeCastNext3Month { get; set; }
        public double MaxOrderQuantityInMonth { get; set; }
        public double OrderQuantityInYear { get; set; }
        public double InvQuantityNeed { get; set; }
        public double InvQuantityNeedProduction { get; set; }
        public double InvQuantityNeedProcessing { get; set; }
        public DateTime ReportDate { get; set; }
        public string Next2Month { get; set; }
        public string Next3Month { get; set; }
        public string LastInventoryDate { get; set; }
        public DateTime PrintDate { get; set; }
        public string PrintDateString { get; set; }
    }
}