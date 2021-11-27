using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Method
    {
        public Method()
        {
            this.QuoteForms = new List<QuoteForm>();
            this.QuoteForms1 = new List<QuoteForm>();
            this.QuoteForms2 = new List<QuoteForm>();
            this.QuoteForms3 = new List<QuoteForm>();
        }

        public int MethodId { get; set; }
        public Nullable<int> MethodTypeId { get; set; }
        public string MethodName { get; set; }
        public string MethodName_EN { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<bool> SaleMethod { get; set; }
        public Nullable<bool> BuyMethod { get; set; }
        public virtual MethodType MethodType { get; set; }
        public virtual ICollection<QuoteForm> QuoteForms { get; set; }
        public virtual ICollection<QuoteForm> QuoteForms1 { get; set; }
        public virtual ICollection<QuoteForm> QuoteForms2 { get; set; }
        public virtual ICollection<QuoteForm> QuoteForms3 { get; set; }
    }
}
