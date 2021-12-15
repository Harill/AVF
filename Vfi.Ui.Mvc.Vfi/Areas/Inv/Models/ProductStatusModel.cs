using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class ProductStatusModel {
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double UnitPrice { get; set; }
        public double MaterialUnitWeight { get; set; }

        public int MaterialId { get; set; }
        public string MaterialCode { get; set; }
        public double MaterialPrice { get; set; }

        public double TotalInv { get; set; }

        public DateTime ModifiedDate { get; set; }
        public DateTime? LastProductionDate { get; set; }
        public DateTime? LastFinishInvDate { get; set; }
        public double FinishInv { get; set; }
        public DateTime? LastExportDate { get; set; }
        public DateTime? LastRotateDate { get; set; }
    }
}