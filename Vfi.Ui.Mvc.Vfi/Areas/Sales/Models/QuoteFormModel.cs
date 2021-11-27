using System;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class QuoteFormModel
    {
        public int QuoteId { get; set; }
        public DateTime QuoteDate { get; set; }
        public DateTime OutOfDate { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCodeName { get; set; }

        public int PaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; }
        public int DeliveryTermId { get; set; }
        public string DeliveryTermName { get; set; }
        public int DeliveryPeriod { get; set; }
        public string DeliveryPeriodName { get; set; }
        public int PaymentCondition { get; set; }
        public string PaymentConditionName { get; set; }

        public string Note { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string QuoteNumber { get; set; }
        public int QuoteCount { get; set; }
        public string CurrencyCode { get; set; }
        public double ExchangeRate { get; set; }
        public string PortName { get; set; }
        public int ProductCount { get; set; }
        public int FilterProduct { get; set; }
        public string FilterProductCode { get; set; }
    }
}