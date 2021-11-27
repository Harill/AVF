using System;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class OrderTrackingModel
    {
        public OrderTrackingModel()
        {
            OrderQuantity = 0;
            UnitPrice = 0;
            Currency = "";
        }

        public long OrderId { get; set; }
        public string OrderNumber { get; set; }

        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        //
        public int ProductId { get; set; }
        public string ProductPoNo { get; set; }
        public string ProductCustomerCode { get; set; }
        public string ProductVfCode { get; set; }
        //
        public long OrderDetailId { get; set; }
        public int PoStatus { get; set; }
        public string StatusName { get; set; }
        public double OrderQuantity { get; set; }
        public double RequireQuantity { get; set; }
        public string Currency { get; set; }
        public double UnitPrice { get; set; }
        public string UnitPriceStr
        {
            get
            {
                return Currency.Equals("USD")
                    ? String.Format("{0:n4}", UnitPrice)
                    : String.Format("{0:n0}", UnitPrice);
            }
        }
        public double Amount
        {
            get { return Math.Round(OrderQuantity * UnitPrice, 2); }
        }

        public string AmountStr
        {
            get
            {
                return Currency.Equals("USD")
                    ? String.Format("{0:n2}", OrderQuantity * UnitPrice)
                    : String.Format("{0:n0}", OrderQuantity * UnitPrice);
            }
        }
        public string Note { get; set; }
        public DateTime CustomerDeliveryDate { get; set; }
        public DateTime VfDeliveryDate { get; set; }
        //
        public double ExportQuantity { get; set; }
        public DateTime ExportDateString { get; set; }
        //
        public int AvailableStatus { get; set; }
        public string AvailableStatusName { get; set; }
        public double AvailableTotalInv { get; set; }
        public double AvailableFinishInv{get; set; }
        public DateTime AvailableDate { get; set; }

        public int PlanDay { get; set; }
        public DateTime PlanDeliveryDate { get; set; }
        public string PlanDeliveryDateStr { get; set; }
        public int DayLateStatus
        {
            get
            {
                return CustomerDeliveryDate < DateTime.Now
                    ? 1
                    : VfDeliveryDate < DateTime.Now
                        ? 2
                        : 0;
            }
        }

        public int DayLate
        {
            get
            {
                return DayLateStatus == 1
                    ? (DateTime.Now - CustomerDeliveryDate).Days
                    : DayLateStatus == 2
                        ? (DateTime.Now - VfDeliveryDate).Days
                        : 0;
            }
        }

        public int PlanStatus
        {
            get
            {
                return string.IsNullOrWhiteSpace(PlanDeliveryDateStr)
                    ? 0
                    : PlanDeliveryDate >= CustomerDeliveryDate
                        ? 1
                        : PlanDeliveryDate >= VfDeliveryDate
                            ? 2
                            : 0;
            }
        }

        [UIHint("_DateTemplate")]
        public DateTime? ExpectDate { get; set; }
        public int DeliveryStatus { get; set; }
        public bool SalesManager { get; set; }
        //public string DeliveryStatusName
        //{
        //    get { return MyUtilities.Sales.GetDeliveryStatus(DeliveryStatus); }
        //}
    }
}