using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class EmployeeChart
    {
        public string EmployeeName { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportDateString { get; set; }
        public double TotalSales { get; set; }
        public List<double> Sales { get; set; } 
    }
}