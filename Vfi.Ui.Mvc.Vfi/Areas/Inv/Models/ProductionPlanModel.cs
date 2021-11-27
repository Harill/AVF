using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class ProductionPlanModel {
        public ProductionPlanModel() {
            Productivity = 0;
            Quantity = 0;
            Processing = 0;
            Defect = 0;
            MaterialUse = 0;
            ProductionOrder = new ProductionOrderModel();
        }
        public int MachineId { get; set; }
        public string MachineName { get; set; }

        public int ProductId { get; set; }
        public string ProductCode { get; set; }

        public double Quantity { get; set; }
        public double Processing { get; set; }
        public double Defect { get; set; }
        public double MaterialUse { get; set; }

        public double Productivity { get; set; }
        public double ProductivityInShift {
            get {
                return MyUtilities.Product.GetProductionRateInFactoryShiftTime(Productivity);
                //return MyUtilities.Product.GetProductionRateInTime(MyUtilities.Product.Second10h, Productivity);
            }
        }
        public double ProductivityInDay {
            get {
                return MyUtilities.Product.GetProductionRateInFactoryDayTime(Productivity);
                //return MyUtilities.Product.GetProductionRateInTime(MyUtilities.Product.Second20h, Productivity);
            }
        }
        public double ProductionRate { get; set; }
        public int ProductionDay {
            get {
                return ProductivityInDay > 0
                    ? MyUtilities.Function.RoundUp(ProductionOrder.RequirePerMachine / ProductivityInDay)
                    : 0;
            }
        }

        public ProductionOrderModel ProductionOrder { get; set; }

        public DateTime? LastActive { get; set; }
        public string LastActiveStr { get { return LastActive != null ? LastActive.Value.ToString("dd/MM/yyyy") : ""; } }
    }

    public class ProductionOrderModel {

        public ProductionOrderModel() {
            ProductionDay = 0;
            ProductionDayLeft = 1;
            MachineCount = 0;
            TotalInv = 0;
            Order = 0;
            ForecastInMonth = 0;
            ForecastNextMonth = 0;
            ExportSales = 0;
            TotalRequire = 0;
        }

        public ProductionOrderModel Clone() {
            return new ProductionOrderModel {
                MachineCount = MachineCount,
                TotalInv = TotalInv,
                Order = Order,
                ForecastInMonth = ForecastInMonth,
                ForecastDate = ForecastDate,
                ForecastDateStr = ForecastDateStr,
                ForecastNextMonth = ForecastNextMonth,
                ForecastNextDate = ForecastNextDate,
                ForecastNextDateStr = ForecastNextDateStr,
                ExportSales = ExportSales,
                TotalRequire = TotalRequire,
                RequireDate = RequireDate,
                ProductionDay = ProductionDay,
                ProductionDayLeft = ProductionDayLeft
            };
        }

        public double MachineCount { get; set; }
        public double TotalInv { get; set; }
        public double Order { get; set; }

        public double ForecastInMonth { get; set; }
        public DateTime? ForecastDate { get; set; }
        public string ForecastDateStr { get; set; }

        public double ForecastNextMonth { get; set; }
        public DateTime? ForecastNextDate { get; set; }
        public string ForecastNextDateStr { get; set; }

        public double ExportSales { get; set; }


        public double TotalRequire { get; set; }
        public DateTime? RequireDate { get; set; }
        public string RequireDateStr { get { return RequireDate != null ? RequireDate.Value.ToString("dd/MM/yyyy") : ""; } }

        public int ProductionDay { get; set; }
        public int ProductionAfterDay { get; set; }

        public double RequirePerMachine {
            get {
                return MachineCount > 0 ? TotalRequire / MachineCount : 0;
            }
        }

        public int ProductionDayLeft { get; set; }
        public double RequirePerDay {
            get {
                return ProductionDay > 1 ? RequirePerMachine / ProductionDayLeft : RequirePerMachine;
            }
        }
        // 1 red, 2 orange
        public int AlertColor { get; set; }

    }

}