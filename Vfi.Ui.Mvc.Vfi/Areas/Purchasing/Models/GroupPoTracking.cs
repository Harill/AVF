using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models {
    public class GroupPoTracking {
        public GroupPoTracking() {
            List = new List<PoTracking>();
        }

        public string TypeName { get; set; }

        public DateTime ReportDate { get; set; }
        public string ReportDateStr { get; set; }

        public double Quantity {
            get { return List.Sum(l => l.Quantity); }
        }
        public double TotalPriceUSD {
            get { return List.Sum(l => l.TotalPriceUSD); }
        }
        public double TotalPriceVND {
            get { return List.Sum(l => l.TotalPriceVND); }
        }
        public double TotalPrice {
            get { return List.Sum(l => l.TotalPrice); }
        }

        public double ImportQuantity {
            get { return List.Sum(l => l.ImportQuantity); }
        }
        public double ImportPriceUSD {
            get { return List.Sum(l => l.ImportPriceUSD); }
        }
        public double ImportPriceVND {
            get { return List.Sum(l => l.ImportPriceVND); }
        }
        public double ImportPrice {
            get { return List.Sum(l => l.ImportPrice); }
        }

        public double LastQuantity {
            get { return List.Sum(l => l.LastQuantity); }
        }
        public double LastPriceUSD {
            get { return List.Sum(l => l.LastPriceUSD); }
        }
        public double LastPriceVND {
            get { return List.Sum(l => l.LastPriceVND); }
        }
        public double LastPrice {
            get { return List.Sum(l => l.LastPrice); }
        }

        public List<PoTracking> List { get; set; }
    }

    public class PoTracking {
        public PoTracking() {
            Details = new List<PoTrackingDetail>();
        }
        public double Quantity {
            get { return Details.Sum(d => d.Quantity); }
        }

        public double TotalPriceUSD {
            get { return Details.Sum(d => d.TotalPriceUSD); }
        }
        public double TotalPriceVND {
            get { return Details.Sum(d => d.TotalPriceVND); }
        }
        public double TotalPrice {
            get { return Details.Sum(d => d.TotalPrice); }
        }

        public double ImportQuantity {
            get { return Details.Sum(d => d.ImportQuantity); }
        }

        public double ImportPriceUSD {
            get { return Details.Sum(d => d.ImportPriceUSD); }
        }
        public double ImportPriceVND {
            get { return Details.Sum(d => d.ImportPriceVND); }
        }
        public double ImportPrice {
            get { return Details.Sum(d => d.ImportPrice); }
        }

        public double LastQuantity {
            get { return Details.Sum(d => d.LastQuantity); }
        }
        public double LastPriceUSD {
            get { return Details.Sum(d => d.LastPriceUSD); }
        }
        public double LastPriceVND {
            get { return Details.Sum(d => d.LastPriceVND); }
        }
        public double LastPrice {
            get { return Details.Sum(d => d.LastPrice); }
        }

        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public DateTime PoDate { get; set; }
        public DateTime CreateDate { get; set; }
        public List<PoTrackingDetail> Details { get; set; }
    }

    public class PoTrackingDetail {

        public PoTrackingDetail() {
            UnitPrice = 0;
            Quantity = 0;
            Quantity = 0;
            ExchangeRate = 1;
            ImportDetails = new List<PoTrackingImportDetail>();
        }
        public int Index { get; set; }
        public string PoDetailName { get; set; }
        public string PoDetailDesign { get; set; }
        public string UnitMeasure { get; set; }
        public double UnitPrice { get; set; }
        //public DateTime PoDate { get; set; }
        public string PoDateStr { get; set; }
        //public DateTime CreateDate { get; set; }
        public string CreateDateStr { get; set; }

        public string UnitPriceString {
            get {
                return Currency.Equals("VND")
                           ? string.Format("{0:n0}", UnitPrice)
                           : string.Format("{0:n4}", UnitPrice);
            }
        }

        public string Currency { get; set; }
        public double ExchangeRate { get; set; }
        public double Quantity { get; set; }
        public double ImportedQuantity { get; set; }

        public double TotalPriceUSD {
            get {
                return Currency.Equals("VND")
                           ? 0
                           : Quantity * UnitPrice;
            }
        }

        public double TotalPriceVND {
            get {
                return !Currency.Equals("VND")
                           ? 0
                           : Quantity * UnitPrice;
            }
        }

        public double TotalPrice {
            get {
                return TotalPriceUSD * ExchangeRate + TotalPriceVND;
            }
        }

        public double ImportQuantity {
            get { return ImportDetails.Sum(id => id.ImportQuantity); }
        }

        public double ImportPriceUSD {
            get {
                return Currency.Equals("VND")
                    ? 0
                    : ImportDetails.Sum(id => id.ImportPrice);
            }
        }

        public double ImportPriceVND {
            get {
                return !Currency.Equals("VND")
                    ? 0
                    : ImportDetails.Sum(id => id.ImportPrice);
            }
        }

        public double ImportPrice {
            get { return ImportPriceUSD * ExchangeRate + ImportPriceVND; }
        }

        public double LastQuantity {
            get { return ImportQuantity > Quantity ? 0 : Quantity - ImportQuantity; }
        }

        public double LastPriceUSD {
            get {
                return Currency.Equals("VND")
                    ? 0
                    : LastQuantity * UnitPrice;
            }
        }

        public double LastPriceVND {
            get {
                return !Currency.Equals("VND")
                    ? 0
                    : LastQuantity * UnitPrice;
            }
        }

        public double LastPrice {
            get { return LastPriceUSD * ExchangeRate + LastPriceVND; }
        }

        public List<PoTrackingImportDetail> ImportDetails { get; set; }

        public string InquiryNumber { get; set; }
        public string InquiryDateStr { get; set; }
        public string InquiryStatus { get; set; }
        public int InquiryState { get; set; }
    }

    public class PoTrackingImportDetail {

        public PoTrackingImportDetail() {
            ImportQuantity = 0;
            ExchangeRate = 1;
            UnitPrice = 0;
        }
        public double ImportQuantity { get; set; }
        public string ImportQuantityString {
            get { return ImportQuantity > 0 ? string.Format("{0:n2}", ImportQuantity) : ""; }
        }
        public double ExchangeRate { get; set; }
        public string Currency { get; set; }
        public double UnitPrice { get; set; }
        //public DateTime ImportDate { get; set; }
        public string ImportDateString { get; set; }
        public double ImportPrice {
            get { return ImportQuantity * UnitPrice; }
        }

        public string ImportPriceStringUSD {
            get {
                return ImportPrice > 0
                        ? (!Currency.Equals("VND")
                                ? string.Format("{0:n2}", ImportPrice)
                                : "")
                        : "";
            }
        }

        public string ImportPriceStringVND {
            get {
                return ImportPrice > 0
                        ? (Currency.Equals("VND")
                                ? string.Format("{0:n0}", ImportPrice)
                                : "")
                        : "";
            }
        }

    }
}