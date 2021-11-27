using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionPlan
    {
        public int PlanId { get; set; }
        public System.DateTime PlanDate { get; set; }
        public int PlanType { get; set; }
        public int ProductId { get; set; }
        public double RequireQuantity { get; set; }
        public double ProductivityInDay { get; set; }
        public double RequireQuantityPerDay { get; set; }
        public int MachineFactor { get; set; }
        public double Day1 { get; set; }
        public double Day2 { get; set; }
        public double Day3 { get; set; }
        public double Day4 { get; set; }
        public double Day5 { get; set; }
        public double Day6 { get; set; }
        public double Day7 { get; set; }
        public string Note { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
