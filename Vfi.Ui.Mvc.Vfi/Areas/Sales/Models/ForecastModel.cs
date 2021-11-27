using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class ForecastModel
    {
        public ForecastModel()
        {
            Details = new List<ForecastDetailModel>();
        }
        public int Index { get; set; }
        public int ForecastOrderId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        [DataType("_ProductEditTemplate")]
        public string ProductCode { get; set; }
        [DataType("_DateTemplate")]
        public DateTime ForecastDate { get; set; }
        [DataType("Number0")]
        public double Quantity { get; set; }
        public double LastYearTotalQuantity { get; set; }
        public double LastYearAvgQuantity { get; set; }
        public double LastYearQuantity { get; set; }
        public double LastMonthAvgQuantity { get; set; }
        public double LastMonthQuantity { get; set; }
        public double LastMonthOrderQuantity { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? MaterialEnoughDate { get; set; }
        public bool IsSelling { get; set; }
        public byte Status { get; set; }
        public string StatusName { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string Width
        {
            get { return Details.Count > 0 ? Math.Round(100.00 / Details.Count, 2) - 0.05 + "%" : "99.95%"; }
        }
        public DateTime StartDate { get; set; }

        public string StartDateString
        {
            get { return StartDate.ToString("dd/MM"); }
        }
        public string ForecastDateString { get { return ForecastDate.ToString("dd/MM"); } }
        public int Type { get; set; }
        public List<ForecastDetailModel> Details { get; set; }
        public bool SaleManagement { get; set; }
        public double TotalInv { get; set; }
        public double TotalOrder { get; set; }
    }
}