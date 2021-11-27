using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class FactoryProductionProcessModel {
        public FactoryProductionProcessModel() {
            OrderQuantity = 0;
            ForecastQuantity = 0;
            ExportQuantity = 0;
            AfterInvQuantity = 0;
            InvQuantity = 0;
            Productivity = 0;
            MachineCount = 1;
            //Production1OrdersCalculate = new List<FactoryProduction1ProcessDetail>();
            //Production1ForecastsCalculate = new List<FactoryProduction1ProcessDetail>();
            RealProductions = new List<ProductionDay>();
            OrderQuantityPerDay = 0;
            ForecastQuantityPerDay = 0;
        }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        // 2
        public double LastOrderQuantity { get; set; }
        public double OrderQuantity { get; set; }
        //3
        public double ForecastQuantity { get; set; }
        //4
        public double ExportQuantity { get; set; }
        public double InvQuantity { get; set; }
        //5
        public double AfterInvQuantity { get; set; }
        //6
        public double RequireQuantityCalculate {
            get {
                return Math.Max(OrderQuantity, ForecastQuantity) - AfterInvQuantity;
            }
        }
        //6 saved
        public double RequireQuantitySaved { get; set; }
        //6 
        public double RequireQuantityPlan {
            get {
                return RequireQuantitySaved > 0
                    ? RequireQuantitySaved
                    : RequireQuantityCalculate;
            }
        }
        //7
        public double Productivity { get; set; }
        public double DesignProductivityInDayCalculate {
            get {
                return MyUtilities.Product.GetProductionRateInFactoryDayTime(Productivity);
                //return MyUtilities.Product.GetProductionRateInTime(MyUtilities.Product.Second20h, Productivity);
            }
        }
        public double RealProductivityInDay { get; set; }
        public double ProductivityInDayCalculate {
            get {
                return RealProductivityInDay > 0
                    ? RealProductivityInDay
                    : DesignProductivityInDayCalculate * MachineCount;
            }
        }
        // 7 saved
        public double ProductivityInDaySaved { get; set; }
        // 7
        public double ProductivityInDayPlan {
            get {
                return ProductivityInDaySaved > 0
                    ? ProductivityInDaySaved
                    : ProductivityInDayCalculate;
            }
        }
        //8
        public double MachineCount { get; set; }

        public double RequireQuantityExecuteCalculate {
            get {
                return RequireQuantityCalculate > 0 ? RequireQuantityCalculate : 0;
            }
        }
        // 8 saved
        public double RequireQuantityExecuteSaved { get; set; }
        // 8
        public double RequireQuantityExecutePlan {
            get {
                return RequireQuantityExecuteSaved > 0
                    ? RequireQuantityExecuteSaved
                    : RequireQuantityExecuteCalculate;
            }
        }

        //9.1
        public double OrderQuantityPerDay { get; set; }
        //9.2
        public double ForecastQuantityPerDay { get; set; }
        //9.3
        public double MaxRequirePerDayCalculate {
            get {
                return Math.Max(OrderQuantityPerDay, ForecastQuantityPerDay);
            }
        }
        //9.4
        public double MaxPlanCalculate {
            get {
                return Math.Max(MaxRequirePerDayCalculate, ProductivityInDayCalculate);
            }
        }
        //9.5
        public double WeeklyPlanCalculate {
            get {
                return MaxPlanCalculate * 6;
            }
        }

        //public List<FactoryProduction1ProcessDetail> Production1OrdersCalculate { get; set; }
        //public double MaxOrderCalculate { get; set; }
        //public List<FactoryProduction1ProcessDetail> Production1ForecastsCalculate { get; set; }
        //public double MaxForecastCalculate { get; set; }

        public List<ProductionDay> RealProductions { get; set; }
        public double ProductionCountCalculate { get { return RealProductions.Sum(rp => rp.ProductionCount); } }
        // 11 calculate
        public double ProductionQuantityCalculate { get { return RealProductions.Sum(rp => rp.ProductionQuantityCalculate); } }
        // 11 reality
        public double ProductionQuantity { get { return RealProductions.Sum(rp => rp.ProductionQuantity); } }
        // 11 saved
        public double ProductionQuantitySaved { get { return RealProductions.Sum(rp => rp.ProductionQuantitySaved); } }

        // 12
        public double WeeklyPlanExecuteCalculate {
            get {
                return WeeklyPlanCalculate - ProductionQuantity;
            }
        }
        // 13
        public double WeeklyPlanRateCalculate {
            get {
                return WeeklyPlanCalculate > 0 ? ProductionQuantity / WeeklyPlanCalculate : 0;
            }
        }


        //public double RealProductionCount { get { return RealProductions.Sum(rp => rp.ProductionCount); } }
        //public double PlanProductionQuantity { get { return RealProductionCount * MaxRequireCalculate; } }
        //public double ProductionRate {
        //    get {
        //        return PlanProductionQuantity > 0
        //            ? RealProductionQuantity / PlanProductionQuantity * 100
        //            : RealProductionQuantity > 0
        //                ? 100
        //                : 0;
        //    }
        //}

        // 14
        public string OrderNote { get; set; }
        //public string OrderNote {
        //    get {
        //        var str = "";
        //        for (int i = 0; i < Production1OrdersCalculate.Count; i++) {
        //            if (i == 2) break;
        //            var order = Production1OrdersCalculate[i];
        //            str += (order.RequiredDate.ToString("dd/MM") + ":" + string.Format("{0:n0}", order.OrderQuantity) + " | ");
        //        }
        //        return str;
        //    }
        //}

    }

    public class ProductionDay {
        public DateTime ProductionDate { get; set; }
        public string DayOfWeek { get; set; }
        public int ProductionCount { get; set; }
        // 10.1
        public double ProductionQuantityCalculate { get; set; }
        public double ProductionQuantitySaved { get; set; }
        public double ProductionQuantity { get; set; }
    }


    //public class FactoryProduction1ProcessDetail {
    //    public FactoryProduction1ProcessDetail() {
    //        PlanProductionDay = 0;
    //        RequireQuantity = 0;
    //        AfterInvQuantity = 0;
    //        TotalRequireQuantity = 0;
    //    }

    //    public DateTime RequiredDate { get; set; }
    //    public double InvQuantity { get; set; }
    //    public double AfterInvQuantity { get; set; }
    //    //public double ProductionQuantity { get; set; }
    //    //public double TotalProductionQuantity { get; set; }
    //    public double RequireQuantity { get; set; }
    //    public double OrderQuantity { get; set; }
    //    public double TotalRequireQuantity { get; set; }
    //    public int PlanProductionDay { get; set; }
    //    public double RequirePerDay {
    //        get {
    //            return PlanProductionDay > 0 ? TotalRequireQuantity / PlanProductionDay : TotalRequireQuantity;
    //        }
    //    }

    //    //public double RequireProduction {
    //    //    get {
    //    //        return ProductionQuantity > RequirePerDay ? 0 : ProductionQuantity - RequirePerDay;
    //    //    }
    //    //}
    //}
}