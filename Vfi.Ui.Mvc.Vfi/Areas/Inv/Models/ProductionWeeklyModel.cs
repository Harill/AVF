using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ProductionWeeklyModel
    {
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int MaterialId { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialDesignNo { get; set; }
        public string MaterialInvId { get; set; }

        public double? OrderLast { get; set; }

        public double? OrderNext { get; set; }

        public double? TotalProductInv { get; set; }

        public double? TotalMaterialInv { get; set; }
        public double? TotalMaterialInvKg { get; set; }
        public int ExpectedEndMaterialDay { get; set; }

        public int DailyProduction { get; set; }
        public int MachineRunningDay { get; set; }

        public double? DayOne { get; set; }
        public DateTime DateOne { get; set; }
        public double? DayTwo { get; set; }
        public DateTime DateTwo { get; set; }
        public double? DayThree { get; set; }
        public DateTime DateThree { get; set; }
        public double? DayFour { get; set; }
        public DateTime DateFour { get; set; }
        public double? DayFive { get; set; }
        public DateTime DateFive { get; set; }
        public double? DaySix { get; set; }
        public DateTime DateSix { get; set; }


        public double? OrderLastRemaining { get; set; }
        public DateTime? OrderNextDate { get; set; }
        public double? OrderNextRemaining { get; set; }

        public DateTime ReportDate { get; set; }
    }
}