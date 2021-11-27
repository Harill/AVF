using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
	public class TaxInvoiceDetailModel
    {
        public int DetailId { get; set; }
        public Nullable<int> TaxInvoiceId { get; set; }
        public string TaxInvoiceList { get; set; }
        [Required(ErrorMessage = @"Vui lòng nhập số tien.")]
        [Range(0.01, double.MaxValue, ErrorMessage = @" 0.01 < Slg nhập < max")]
        [DataType("Number")]
        public Nullable<double> Money { get; set; }
        public string MoneyFormat
        {
            get
            {
                return string.IsNullOrWhiteSpace(CurrencyCode)
                           ? ""
                           : CurrencyCode.Equals("VND")
                                 ? string.Format("{0:n0}", Money)
                                 : string.Format("{0:n2}", Money);
            }
        }
        public Nullable<int> Times { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string Note { get; set; }
        public string StatusName { get; set; }
        public DateTime ImportDate { get; set; }
        public int Tax { get; set; }
        public double TotalAmount { get; set; }
        public string TotalAmountFormat
        {
            get
            {
                return string.IsNullOrWhiteSpace(CurrencyCode)
                           ? ""
                           : CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", TotalAmount)
                           : string.Format("{0:n2}", TotalAmount);
            }
        }
        [DataType("Number")]
        public double RequiredAmount { get; set; }
        public string RequiredAmountFormat {
            get
            {
                return string.IsNullOrWhiteSpace(CurrencyCode)
                           ? ""
                           : CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", RequiredAmount)
                           : string.Format("{0:n2}", RequiredAmount);
            }
        }
        public string CurrencyCode { get; set; }
        public string InvoiceNumber { get; set; }
        public string TypeDetail { get; set; }
	}
}