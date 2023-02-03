using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class ProductionWorkOrderModel {
        public int ProductId { get; set; }
        [DataType("Number3Digit")]
        public double ProductionWeight { get; set; }
        [DataType("Int")]
        public int MaxQuantityInTray { get; set; }
        public double MaxWeightInTray { get { return MaxQuantityInTray * ProductionWeight; } }
        [DataType("Number2Digit")]
        public double Productivity { get; set; }
        public double ProductionTime { get { return MaxQuantityInTray * Productivity / 3600; } }

        [DataType("Number2Digit")]
        public double Productivity2 { get; set; }
        public double Production2Time { get { return MaxQuantityInTray * Productivity2 / 3600; } }

        [DataType("Number2Digit")]
        public double ProductivityQC { get; set; }
        public double QCTime { get { return MaxQuantityInTray * ProductivityQC / 3600; } }

        public double ProductivityPacking { get; set; }
        public double PackingTime { get { return MaxQuantityInTray * ProductivityPacking; } }

        [DataType("Int")]
        public int ProductionRate { get; set; }
        public double MaterialRate { get { return ProductionRate > 0 ? MaxQuantityInTray / ProductionRate : 0; } }

        public int MaxQuantityInTrayRunTime { get { return MyUtilities.Function.RoundUp(ProductionTime + Production2Time + QCTime + PackingTime / 3600); } }

        [DataType("Int")]
        public int ProductionLossRate { get; set; }
    }
}