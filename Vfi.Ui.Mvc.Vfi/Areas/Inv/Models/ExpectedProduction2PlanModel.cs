using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class ExpectedProduction2PlanModel {
        public ExpectedProduction2PlanModel() {
            Sections = new List<ExpectedProduction2PlanSection>();
            Orders = new List<ExpectedProduction2PlanInfo>();
            Forecasts = new List<ExpectedProduction2PlanInfo>();
        }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }

        public List<ExpectedProduction2PlanSection> Sections { get; set; }
        public int SectionCount { get { return Sections.Count; } }
        public double SmallestProductivity { get { return Sections.Any() ? Sections.Min(x => x.Productivity) : 0; } }

        public double ProductivityInDay {
            get {
                return MyUtilities.Product.GetProductionRateInDayTime(SmallestProductivity);
                //return MyUtilities.Product.GetProductionRateInTime(MyUtilities.Product.Second7_5h, SmallestProductivity);
            }
        }

        public double FinishInv { get; set; }
        public double BeforeProduction2Inv { get; set; }
        public int BeforeProduction2Day { get; set; }
        public double TotalInv { get; set; }
        public double Production2Inv { get; set; }
        public double ExportFinish { get; set; }

        public List<ExpectedProduction2PlanInfo> Orders { get; set; }
        public List<ExpectedProduction2PlanInfo> Forecasts { get; set; }
        public double OrderQuantity { get { return Orders.Sum(o => o.Quantity); } }
        public double OrderRequire { get { return Orders.Sum(o => o.RequireQuantity); } }
        public double OrderSecond { get { return Orders.Sum(o => o.Second); } }
        public DateTime? OrderDueDate { get { return Orders.Any() ? Orders.Min(x => x.Date) : (DateTime?)null; } }
        public DateTime? OrderStartDate { get { return Orders.Any() ? Orders.Min(x => x.StartDate) : (DateTime?)null; } }
        public DateTime? OrderEndDate { get { return Orders.Any() ? Orders.Max(x => x.EndDate) : (DateTime?)null; } }
        public double ForecastQuantity { get { return Forecasts.Sum(o => o.Quantity); } }
        public double ForecastRequire { get { return Forecasts.Sum(o => o.RequireQuantity); } }
        public double ForecastSecond { get { return Forecasts.Sum(o => o.Second); } }
        public DateTime? ForecastDueDate { get { return Forecasts.Any() ? Forecasts.Min(x => x.Date) : (DateTime?)null; } }
        public DateTime? ForecastStartDate { get { return Forecasts.Any() ? Forecasts.Min(x => x.StartDate) : (DateTime?)null; } }
        public DateTime? ForecastEndDate { get { return Forecasts.Any() ? Forecasts.Max(x => x.EndDate) : (DateTime?)null; } }
        public DateTime Date { get { return OrderDueDate != null ? OrderDueDate.Value : ForecastDueDate.Value; } }
    }

    public class ExpectedProduction2PlanSection {
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public double Productivity { get; set; }
    }
    public class ExpectedProduction2PlanInfo {
        public double Quantity { get; set; }
        public double RequireQuantity { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Second { get; set; }
    }
}