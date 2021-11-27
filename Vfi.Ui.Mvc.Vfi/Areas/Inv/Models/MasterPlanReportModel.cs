using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class ProductMasterPlanReportModel {
        public DateTime ReportDate { get; set; }
        public long Section { get; set; }
        public ProductMasterPlanReportModel() {
            Section = 0;
            OrderPlans = new List<OrderPlanReportModel>();
            ForecastPlans = new List<ForecastPlanReportModel>();
            ProductionOrderPlans = new List<ProductionOrderPlanReportModel>();
            ProductionForecastPlans = new List<ProductionForecastPlanReportModel>();
            CncOrderPlans = new List<CncOrderPlanReportModel>();
            CncForecastPlans = new List<CncForecastPlanReportModel>();
            Production2OrderPlans = new List<Production2OrderPlanReportModel>();
            Production2ForecastPlans = new List<Production2ForecastPlanReportModel>();
            QcOrderPlans = new List<QcOrderPlanReportModel>();
            QcForecastPlans = new List<QcForecastPlanReportModel>();
            OrderLatedPlans = new List<OrderLatePlanReportModel>();
        }
        public OrderPlanReportModel OrderPlanTotal {
            get {
                return new OrderPlanReportModel() {
                    LastMonth = OrderPlans.Sum(op => op.LastMonth),
                    InMonth = OrderPlans.Sum(op => op.InMonth),
                    NextMonth = OrderPlans.Sum(op => op.NextMonth),
                    AccumulatedExport = OrderPlans.Sum(op => op.AccumulatedExport),
                };
            }
        }
        public ForecastPlanReportModel ForecastPlanTotal {
            get {
                return new ForecastPlanReportModel() {
                    InMonth = ForecastPlans.Sum(op => op.InMonth),
                    NextMonth = ForecastPlans.Sum(op => op.NextMonth),
                    AccumulatedExport = ForecastPlans.Sum(op => op.AccumulatedExport),
                };
            }
        }
        public List<OrderPlanReportModel> OrderPlans { get; set; }
        public List<ForecastPlanReportModel> ForecastPlans { get; set; }
        public List<ProductionOrderPlanReportModel> ProductionOrderPlans { get; set; }
        public List<ProductionForecastPlanReportModel> ProductionForecastPlans { get; set; }
        public List<CncOrderPlanReportModel> CncOrderPlans { get; set; }
        public List<CncForecastPlanReportModel> CncForecastPlans { get; set; }
        public List<Production2OrderPlanReportModel> Production2OrderPlans { get; set; }
        public List<Production2ForecastPlanReportModel> Production2ForecastPlans { get; set; }
        public List<QcOrderPlanReportModel> QcOrderPlans { get; set; }
        public List<QcForecastPlanReportModel> QcForecastPlans { get; set; }
        public List<OrderLatePlanReportModel> OrderLatedPlans { get; set; }
    }
    public class BaseInfoPlanReportModel {
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
    }
    public class OrderPlanReportModel {
        public BaseInfoPlanReportModel Info { get; set; }
        public double LastMonth { get; set; }
        public double InMonth { get; set; }
        public double NextMonth { get; set; }
        public double Total { get { return LastMonth + InMonth + NextMonth; } }
        public double AccumulatedExport { get; set; }
        public double PlanRequired { get { return Total - AccumulatedExport; } }
    }

    public class ForecastPlanReportModel {
        public BaseInfoPlanReportModel Info { get; set; }
        public double InMonth { get; set; }
        public double NextMonth { get; set; }
        public double Total { get { return InMonth + NextMonth; } }
        public double AccumulatedExport { get; set; }
        public double PlanRequired { get { return Total - AccumulatedExport; } }
    }

    public class OrderLatePlanReportModel {
        public BaseInfoPlanReportModel Info { get; set; }
        public double OrderQuatity { get; set; }
        public double ExportQuantity { get; set; }
        public double PlanRequired { get { return OrderQuatity - ExportQuantity; } }
        public string State { get; set; }
    }

    public class ProcessState {
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public double PlanRequired { get; set; }
    }

    public class BasePlanReportModel {
        public BaseInfoPlanReportModel Info { get; set; }
        public double TotalOrder { get; set; }
        public double AccumulatedExport { get; set; }
        public double InvQuantity { get; set; }
        public double AfterInvQuantity { get; set; }
        public double ProductionRequired { get { return TotalOrder - AccumulatedExport - AfterInvQuantity; } }
        public double Productivity { get; set; }
    }
    // ========== Production
    public class ProductionOrderPlanReportModel : BasePlanReportModel {
        public bool IsProduction { get; set; }
        public string State { get { return IsProduction ? "Đang SX" : "Chưa SX"; } }
        public double ProductivityInDay {
            get {
                return MyUtilities.Product.GetProductionRateInFactoryShiftTime(this.Productivity);
                //return MyUtilities.Product.GetProductionRateInTime(MyUtilities.Product.Second10h, this.Productivity);
            }
        }
        public string MachineType { get; set; }
        public int ProductionDay {
            get {
                return ProductivityInDay > 0
                    ? MyUtilities.Function.RoundUp(ProductionRequired / ProductivityInDay)
                    : 1;
            }
        }
    }
    public class ProductionForecastPlanReportModel : BasePlanReportModel {
        public bool IsProduction { get; set; }
        public string State { get { return IsProduction ? "Đang SX" : "Chưa SX"; } }
        public double ProductivityInDay {
            get {
                return MyUtilities.Product.GetProductionRateInFactoryShiftTime(this.Productivity);
                //return MyUtilities.Product.GetProductionRateInTime(MyUtilities.Product.Second10h, this.Productivity);
            }
        }
        public string MachineType { get; set; }
        public int ProductionDay {
            get {
                return ProductivityInDay > 0
                    ? MyUtilities.Function.RoundUp(ProductionRequired / ProductivityInDay)
                    : 1;
            }
        }
    }

    // ========== Phay CNC
    public class CncOrderPlanReportModel : BasePlanReportModel {
        public bool IsProduction { get; set; }
        public string State { get { return IsProduction ? "Đang SX" : "Chưa SX"; } }
        public double ProductivityInDay {
            get {
                return MyUtilities.Product.GetProductionRateInFactoryShiftTime(this.Productivity);
                //return MyUtilities.Product.GetProductionRateInTime(MyUtilities.Product.Second10h, this.Productivity);
            }
        }
        public int ProductionDay {
            get {
                return ProductivityInDay > 0
                    ? MyUtilities.Function.RoundUp(ProductionRequired / ProductivityInDay)
                    : 1;
            }
        }
    }
    public class CncForecastPlanReportModel : BasePlanReportModel {
        public bool IsProduction { get; set; }
        public string State { get { return IsProduction ? "Đang SX" : "Chưa SX"; } }
        public double ProductivityInDay {
            get {
                return MyUtilities.Product.GetProductionRateInFactoryShiftTime(this.Productivity);
                //return MyUtilities.Product.GetProductionRateInTime(MyUtilities.Product.Second10h, this.Productivity);
            }
        }
        public int ProductionDay {
            get {
                return ProductivityInDay > 0
                    ? MyUtilities.Function.RoundUp(ProductionRequired / ProductivityInDay)
                    : 1;
            }
        }
    }

    // ========== SX2
    public class Production2OrderPlanReportModel : BasePlanReportModel {
        public string State { get; set; }
        public double ProductivityInDay {
            get {
                return MyUtilities.Product.GetProductionRateInDayTime(this.Productivity);
                //return MyUtilities.Product.GetProductionRateInTime(MyUtilities.Product.Second7_5h, this.Productivity);
            }
        }
        public int ProductionDay {
            get {
                return ProductivityInDay > 0
                    ? MyUtilities.Function.RoundUp(ProductionRequired / ProductivityInDay)
                    : 1;
            }
        }
    }
    public class Production2ForecastPlanReportModel : BasePlanReportModel {
        public string State { get; set; }
        public double ProductivityInDay {
            get {
                return MyUtilities.Product.GetProductionRateInDayTime(this.Productivity);
                //return MyUtilities.Product.GetProductionRateInTime(MyUtilities.Product.Second7_5h, this.Productivity);
            }
        }
        public int ProductionDay {
            get {
                return ProductivityInDay > 0
                    ? MyUtilities.Function.RoundUp(ProductionRequired / ProductivityInDay)
                    : 1;
            }
        }
    }

    // ========== QC
    public class QcOrderPlanReportModel : BasePlanReportModel {
        public string State { get; set; }
    }
    public class QcForecastPlanReportModel : BasePlanReportModel {
        public string State { get; set; }
    }
}