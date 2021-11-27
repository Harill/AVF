using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class ForecastDetailModel
    {
        public ForecastDetailModel()
        {
            //StartDate = new DateTime();
            //EndDate = new DateTime();
            //ForecastDate = new DateTime();
            ModifiedDate = DateTime.Now;
            WarehouseInv = 0;
            ForecastQuantity = 0;
            Productivity = 0;
            Index = 0;
            Processes = new List<ForecastDetailProcess>();
            Orders = new List<OrderDetailProcess>();
        }
        public int CustomerId { get; set; }
        public long DetailId { get; set; }
        public int ForecastOrderId { get; set; }
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double WarehouseInv { get; set; }
        public double AfterInv { get; set; }
        public double TotalInv { get; set; }
        public double Productivity { get; set; }
        public string Note { get; set; }
        public double ProductivityInDay { get; set; }
        public double ProductivityInDay1 { get; set; }
        public int MachineCount { get; set; }
        public double RealProduction { get; set; }
        public double RealProduction1 { get; set; }
        public double RealProduction2 { get; set; }
        public double RealProduction3 { get; set; }
        public double RequireProduction { get; set; }
        public double RequireProductionOrder { get; set; }

        public double DiffProduction
        {
            get
            {
                return RequireProduction > RealProduction
                           ? RealProduction -
                             RequireProduction
                           : 0;
            }
        }

        public int Index { get; set; }
        [DataType("_DateTemplate")]
        public DateTime? StartDate { get; set; }
        public int ProcessId { get; set; }
        public string StartDateString
        {
            get { return StartDate != null ? StartDate.Value.ToString("dd/MM") : ""; }
        }

        [DataType("_DateTemplate")]
        public DateTime? EndDate { get; set; }
        public DateTime? EndDate2 { get; set; }
        public DateTime? EndDate3 { get; set; }
        public string EndDateString
        {
            get { return EndDate != null ? EndDate.Value.ToString("dd/MM") : ""; }
        }
        [DataType("_DateTemplate")]
        public DateTime? ForecastDate { get; set; }
        public DateTime? NextForecastDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? NextOrderDate { get; set; }
        [DataType("Number0")]
        public double ForecastQuantity { get; set; }
        public double ForecastNextMonth { get; set; }
        public double ProcessQuantity { get; set; }
        public double ProcessQuantity1 { get; set; }
        public double ProcessQuantity2 { get; set; }
        public double LastOrderQuantity { get; set; }
        public double OrderQuantity { get; set; }
        public double ExportQuantity { get; set; }
        public double ExportInMonthQuantity { get; set; }
        [DataType("_DateTemplate")]
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public bool IsWorking { get; set; }
        public int ProductionDay { get; set; }
        public int Status { get; set; }
        public int TotalDay
        {
            get
            {
                return ForecastDate > StartDate
                           ? Convert.ToInt32((ForecastDate - StartDate).Value.TotalDays)
                           : 0;
            }
        }
        public int Days { get; set; }
        public int Day
        {
            get
            {
                return StartDate != null
                           ? Convert.ToInt32((DateTime.Now - StartDate).Value.TotalDays)
                           : 0;
            }
        }

        public int Percent { get; set; }
        //public long Percent
        //{
        //    get
        //    {
        //        return (WarehouseInv > ForecastQuantity && ForecastQuantity > 0)
        //                   ? 100
        //                   : Convert.ToInt32((WarehouseInv/ForecastQuantity)*100);
        //    }
        //}

        public string ForecastQuantityString
        {
            get { return string.Format("{0:n0}", ForecastQuantity); }
        }
        public string TotalInvString
        {
            get { return string.Format("{0:n0}", TotalInv); }
        }

        public string WarehouseInvString
        {
            get { return string.Format("{0:n0}", WarehouseInv); }
        }
        public string TextFormat
        {
            get { return Percent < 30 ? "color:black;" : ""; }
        }
        public string RedAltert
        {
            get { return (ForecastDate <= DateTime.Now && WarehouseInv <= 0) ? "background-color:#ff1000;" : ""; }
        }
        public int Type
        {
            get
            {
                // đủ SL xanh lá
                if (Percent == 100) return -1;
                // đã trễ đỏ
                if (ForecastDate <= DateTime.Now) return 2;
                ////sẽ trễ vàng
                if (IsWorking) return 1;
                //bình thường
                return 0;
            }
        }
        public string TypeString
        {
            get
            {
                switch (Type)
                {
                    case 0:
                        return "progress-bar-info";
                    case 1:
                        return "progress-bar-warning";
                    case 2:
                        return "progress-bar-danger";
                    default:
                        return "progress-bar-success";
                }
            }
        }
        public List<ForecastDetailProcess> Processes { get; set; }
        public List<OrderDetailProcess> Orders { get; set; }

        public string OrderNote
        {
            get { 
                var note = "";
                foreach (var order in Orders)
                {
                    note += (order.DateStr + "(" + string.Format("{0:n0}", order.OrderQuantity) + "),");
                }
                return note;
            }
        }
        public string ProcessNote
        {
            get
            {
                var note = "";
                foreach (var process in Processes)
                {
                    if (process.RequireQuantity > 0)
                        note += process.WarehouseName + ",";
                    else break;
                }
                return note;
            }
        }
    }

    public class ForecastDetailProcess
    {
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public double TotalInv { get; set; }
        public double RequireQuantity { get; set; }
        public int ProcessDay { get; set; }
    }

    public class OrderDetailProcess
    {
        public DateTime Date { get; set; }
        public string DateStr { get; set; }
        public double OrderQuantity { get; set; }
    }

    public class ForecastDetailInfo
    {
        public ForecastDetailInfo()
        {
            Date = DateTime.Now;
            List = new List<ForecastDetailInfoList>();
        }

        public DateTime Date { get; set; }
        public string DateString { get; set; }
        public double Count { get; set; }

        public string CountString
        {
            get
            {
                return WarehouseId != MyUtilities.Warehouse.Production2
                           ? string.Format("{0:n0}", Count)
                           : string.Format("{0:n2}", Count) + "%_(" + string.Format("{0:n2}", Sum) + "%)";
            }
        }

        public double Sum { get; set; }
        public string Note { get; set; }
        public string ProductCode { get; set; }
        public int WarehouseId { get; set; }
        public List<ForecastDetailInfoList> List { get; set; }
        public string Description { get; set; }
        public string Production1Note
        {
            get
            {
                var str = "";
                if (List.Count > 0)
                {
                    foreach (var info in List)
                    {
                        str += (info.ProductCode + ",");
                    }
                }
                return str;
            }
        }
        public string Production2Note
        {
            get
            {
                var str = "";
                if (List.Count > 0)
                {
                    foreach (var info in List)
                    {
                        str += (info.ProductCode
                                 + "(" +
                                 Math.Round(
                                     info.ForecastQuantity * 100 / MyUtilities.Section.Total, 2)
                                 + "%), ");
                    }
                }
                return str;
            }
        }
    }

    public class ForecastDetailInfoList
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double ForecastQuantity { get; set; }
        public string Note { get; set; }
    }
}