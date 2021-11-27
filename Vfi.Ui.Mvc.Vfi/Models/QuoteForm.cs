using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class QuoteForm
    {
        public QuoteForm()
        {
            this.QuoteDetails = new List<QuoteDetail>();
        }

        public int QuoteId { get; set; }
        public System.DateTime QuoteDate { get; set; }
        public int CustomerId { get; set; }
        public int PaymentMethodId { get; set; }
        public int DeliveryPeriodId { get; set; }
        public System.DateTime OutOfDate { get; set; }
        public string Note { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string QuoteNumber { get; set; }
        public Nullable<int> QuoteCount { get; set; }
        public Nullable<byte> Status { get; set; }
        public string CurrencyCode { get; set; }
        public string PortName { get; set; }
        public Nullable<double> ExchangeRate { get; set; }
        public Nullable<int> DeliveryTerm { get; set; }
        public Nullable<int> PaymentCondition { get; set; }
        public Nullable<int> SalesPersonId { get; set; }
        public virtual Method Method { get; set; }
        public virtual Method Method1 { get; set; }
        public virtual Method Method2 { get; set; }
        public virtual Method Method3 { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<QuoteDetail> QuoteDetails { get; set; }
    }
}
