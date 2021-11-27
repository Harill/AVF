using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public class ProductionMonitorModel
    {
        public ProductionMonitorModel ()
        {
            ProductivityDesign = 0;
            ProductivityReal = 0;
            ProductionQuantity = 0;
            AvgProductionQuantity = 0;
        }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double ProductivityDesign { get; set; }
        public double ProductivityReal { get; set; }
        public double AvgProductionQuantity { get; set; }
        public double ProductionQuantity { get; set; }
        public int MachineCount { get; set; }
        public bool MissInfo { get; set; }
        //20h * 60 * 5
        public double ProductivityDesignPrice
        {
            get { return ProductivityDesign * 6000; }
        }
        public double ProductivityRealPrice
        {
            get { return ProductivityReal * 6000; }
        }
        public double ProductionQuantityPrice
        {
            get { return AvgProductionQuantity * 5; }
        }
    }
}