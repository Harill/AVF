using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {

    public class ProductionBalancingModel  {
        public ProductionBalancingModel() {
            Production1 = new ProductionBalancingModelDetail();
            Cnc = new ProductionBalancingModelDetail();
            Production2 = new ProductionBalancingModelDetail();
            PoDate = DateTime.Now;
            PoQuantity = 0;
            //PlanProductionDay = 0;
            ProductionDay = 0;
            PenaltyDay = 5;
        }

        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string Type { get; set; }
        public double PoQuantity { get; set; }
        public double RequireQuantity { get; set; }
        public double TotalInv { get; set; }
        public double PlatingInv { get; set; }
        public double QcInv { get; set; }
        public double FinishInv { get; set; }
        public double PackingInv { get; set; }
        public double ExportInv { get; set; }
        public DateTime PoDate { get; set; }
        public int PenaltyDay { get; set; }
        public DateTime RequireImportQcDate {
            get {
                return PoDate.AddDays(PenaltyDay * -1);
            }
        }
        //public int PlanDay { get; set; }
        public int ProductionDay { get; set; }
        public int PlanProductionDay {
            get {
                return RequireImportQcDate > DateTime.Now.Date
                    ? MyUtilities.Function.RoundUp((RequireImportQcDate - DateTime.Now.Date).TotalDays * 6 / 7) 
                    : 1;
            }
        }
        public string PlanImportQcDateString { get { return ProductionDay > 0 ? DateTime.Now.Date.AddDays(ProductionDay).ToString("dd/MM/yyyy") : ""; } }
        //public int RequireProductionDay {
        //    get {
        //       return PlanImportQcDate != null ? MyUtilities.Function.RoundUp((PlanImportQcDate.Value - RequireImportQcDate).TotalDays) : 0;
        //    }
        //}
        public ProductionBalancingModelDetail Production1 { get; set; }
        public ProductionBalancingModelDetail Cnc { get; set; }
        public ProductionBalancingModelDetail Production2 { get; set; }
        public string CamesDate { get; set; }
        public string CncDate { get; set; }
        public string PhayCncDate { get; set; }
        public string Production2Date { get; set; }

        public int DayCount { get; set; }
        public double AvgProduction1 { get; set; }
        public double AvgProduction2 { get; set; }
        public double AvgCnc { get; set; }

    }

    public class ProductionBalancingModelDetail {
        public ProductionBalancingModelDetail() {
            PlanProductionDay = 0;
            RequireQuantity = 0;
            ProductionQuantity = 0;
            Process = 0;
            AfterInvQuantity = -1;
            TotalRequireQuantity = 0;
        }

        public int Process { get; set; }
        public double InvQuantity { get; set; }
        public double AfterInvQuantity { get; set; }
        public double ProductionQuantity { get; set; }
        public double TotalProductionQuantity { get; set; }
        public double Productivity { get; set; }
        public double ProductionRatePerDay { get; set; }
        public double RequireQuantity { get; set; }
        public double TotalRequireQuantity { get; set; }
        public int ProductionDay { get { return TotalProductionQuantity > 0 ? MyUtilities.Function.RoundUp(TotalRequireQuantity / TotalProductionQuantity) : 0; } }
        public double PlanProductionDay { get; set; }
        public double RequirePerDay {
            get {
                return PlanProductionDay > 0 ? RequireQuantity / PlanProductionDay : RequireQuantity;
            }
        }

        public double RequireProduction {
            get {
                return ProductionQuantity > RequirePerDay ? 0 : ProductionQuantity - RequirePerDay;
            }
        }
    }


}