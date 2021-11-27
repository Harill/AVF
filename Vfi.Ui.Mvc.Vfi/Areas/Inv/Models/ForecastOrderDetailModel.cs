using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ForecastOrderDetailModel
    {
        public int Index { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CustomerProductCode { get; set; }
        public string ProductCode { get; set; }
        public string MaterialCode { get; set; }
        public double PlanQuantity { get; set; }
        public double RealQuantity { get; set; }
        public double TotalInventory { get; set; }
        public double FinishInventory { get; set; }
        public DateTime UploadDate { get; set; }
        public string Note { get; set; }
    }

    public class ForecastOrderModel
    {
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public double TotalPlanQuantity { get; set; }
        public double RealQuantity { get; set; }
        public double TotalTotalInventory { get; set; }
        public double TotalFinishInventory { get; set; }
        public DateTime ReportDate { get; set; }
        public List<ForecastOrderDetailModel> Details { get; set; } 
    }
}