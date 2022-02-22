using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public class FuelModel
    {
        public int FuelId { get; set; }
        public string FuelName { get; set; }
        public string FuelCode { get; set; }
        public string FuelDesctiption { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string FuelFullCode { get; set; }
        public string FuelDesignNo { get; set; }
        public double UnitPrice { get; set; }
        public double UnitWeight { get; set; }
        public string FuelFullCodeName
        {
            get { return FuelName+"-"+FuelFullCode; }
            set { FuelName = value; }
        }

        public string GetFuelFullCode()
        {
            string a = "";
            a = FuelCode + "-" + FuelDesignNo;
            return a;
        }

        public string GetFuelFullCode(FuelModel model)
        {
            string a = "";
            if (model != null)
            {
                a = model.FuelCode + "-" + model.FuelDesignNo;
            }
            return a;
        }

        public int Quota { get; set; }
        public double CrossWeight { get; set; }

        public string ProductionFuelId { get { return FuelId + ":" + Quota + ":" + CrossWeight + ":" + UnitWeight; } }
    }
}