using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class ProductionFuelModel
    {
        public int RealId { get; set; }
        [DataType("Int")]
        public int Priority { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }

        public int FuelId { get; set; }
        [UIHint("_FuelEditTemplate")]
        public string FuelFullCodeName
        {
            get { return FuelName + "-" + FuelFullCode; }
            set { FuelName = value; }
        }
        public string FuelFullCode { get; set; }
        public string FuelCode { get; set; }
        public string FuelName { get; set; }
        public string FuelDesign { get; set; }
        [DataType("Int")]
        public int Quota { get; set; }
        [DataType("Number0")]
        public double CrossWeight { get; set; }

        public Nullable<int> Fuel2Id { get; set; }
        [UIHint("_FuelEditTemplate")]
        public string FuelFullCodeName2 {
            get { return FuelName2 + "-" + FuelFullCode2; }
            set { FuelName2 = value; }
        }
        public string FuelFullCode2 { get; set; }
        public string FuelCode2 { get; set; }
        public string FuelName2 { get; set; }
        [DataType("Int")]
        public int Quota2 { get; set; }
        [DataType("Number0")]
        public double CrossWeight2 { get; set; }

        public string Note { get; set; }
        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}