using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production {
    public class ProductQuoteCalculateModel {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double UnitWeight { get; set; }

        public double MaterialPrice { get; set; }
        public double Production2Price { get; set; }
        public double OutsideProductionPrice { get; set; }
        public double ShippingPrice { get; set; }
        public double MaterialTypeFactor { get; set; }

        public double PackingFee { get; set; }
        public double PackingPrice { get; set; }

        public double Productivity { get; set; }
        public string MachineTypeName { get; set; }
        public double MachineClassifiedFactor { get; set; }
        public string ProductLevel { get; set; }
        public double ProductLevelFactor { get; set; }
        public string MaterialTypeName { get; set; }
        public double MaterialProductionFactor { get; set; }

        public double AdditionFee { get; set; }

        public double ProductionPrice {
            get {
                return Math.Round(Productivity * MachineClassifiedFactor * ProductLevelFactor * MaterialProductionFactor, 4);
            }
        }

        public double MaterialTaxFactor { get; set; }

        public double BasePrice {
            get {
                return Math.Round(
                    ((MaterialPrice + ProductionPrice + Production2Price + OutsideProductionPrice)
                    * PackingPrice * MaterialTypeFactor
                    + ShippingPrice + AdditionFee)
                    * MaterialTaxFactor, 4);
            }
        } 
        // ((0.0122 + 0.0297 + 0 + 0) * 1.01 * 1 + 0.0027) * 1.03
        public double MaterialExpensivePrice { get; set; }
        public double QuotePrice { get { return Math.Max(BasePrice, MaterialExpensivePrice); } }
        public bool IsCalculateLock { get; set; }
        public bool CanLock { get; set; }
    }
}