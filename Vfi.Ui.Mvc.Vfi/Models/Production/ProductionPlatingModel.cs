using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production
{
    public class ProductionPlatingModel
    {
        public int PlatingId { get; set; }
        [DataType("_OutsideProcessEditTemplate")]
        public string PlatingName { get; set; }
        public string Description { get; set; }
        [DataType("Number4Digit")]
        public double PlatingCost { get; set; }
        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string ProductPlatingCode { get { return ProductCode + "-" + PlatingName; } }
        public DateTime InsertDate { get; set; }
        public string InserUser { get; set; }
        public int IsProductionManagement { get; set; }
        public int IsSaleManagement { get; set; }

        public string Thickness { get; set; }
        public string SaltSprayTime { get; set; }

        [DataType("Int")]
        public int PlatingIndex { get; set; }
        [DataType("Int")]
        public int PlatingDay { get; set; }
        public bool IsMainProcess { get; set; }

        public int OutsideProcessId { get; set; }
        public double ProcessPrice { get; set; }
        public double UnitWeight { get; set; }
    }
}