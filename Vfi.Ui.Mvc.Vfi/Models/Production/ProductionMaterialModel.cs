using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production
{
    public class ProductionMaterialModel
    {
        public int RealMaterialId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        [UIHint("_ProductEditTemplate")]
        public string ProductCode { get; set; }
        public int MaterialId { get; set; }
        [UIHint("_MaterialEditTemplate")]
        public string MaterialCode { get; set; }
        public int Priority { get; set; }
        public string Note { get; set; }
        [DataType("Number")]
        public double UnitWeightByMaterial { get; set; }

        public double ProductWeight { get; set; }
        public double MaterialInv { get; set; }
        public double MaterialInvKg { get; set; }
        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public double ForecastInYear { get; set; }
        public double ForecastIn3Month
        {
            get { return Math.Round(ForecastInYear/4, 0); }
        }
    }
}