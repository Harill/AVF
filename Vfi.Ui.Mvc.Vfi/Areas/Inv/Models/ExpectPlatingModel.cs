using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ExpectPlatingModel
    {
        public int Index { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public string ProductCustomerCode { get; set; }
        public double WaitingPlatingWeight { get; set; }
        public double WaitingPlatingInv { get; set; }
        public double WaitingPlatingInvWeight { get; set; }
        public double PlatingInv { get; set; }
        public double PlatingTestInv { get; set; }
        public double FinishInv { get; set; }
        public double TotalInv { get; set; }
        public double Production2Inv { get; set; }
        public double QcBInv { get; set; }
        public double OrderQuantity { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderDateString { get; set; }
        public DateTime PlanDate { get; set; }
        public string PlanDateString { get; set; }
        public List<ExpectPlatingDetailModel> Details { get; set; }
        public bool Show { get; set; }
    }
    public class ExpectPlatingDetailModel
    {
        public int Index { get; set; }
        public double OrderQuantity { get; set; }
        public DateTime OrderDate { get; set; }
        public String OrderDateString { get; set; }
    }
    public class ExpectPlatingGroupModel
    {
        public int ProductCount { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string ProductCustomerCode { get; set; }
        public double WaitingPlatingInv { get; set; }
        public double WaitingPlatingInvWeight { get; set; }
        public double PlatingInv { get; set; }
        public double FinishInv { get; set; }
        public double PlatingTestInv { get; set; }
        public double TotalInv { get; set; }
        public double Production2Inv { get; set; }
        public double QcBInv { get; set; }
        public double OrderQuantity { get; set; }
        public List<ExpectPlatingModel> List { get; set; }
        public DateTime ReportDate { get; set; }
    }
}