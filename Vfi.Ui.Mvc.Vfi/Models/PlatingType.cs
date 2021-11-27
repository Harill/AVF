using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class PlatingType
    {
        public PlatingType()
        {
            this.QuoteDetails = new List<QuoteDetail>();
        }

        public int PlatingId { get; set; }
        public string PlatingName { get; set; }
        public string Description { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual ICollection<QuoteDetail> QuoteDetails { get; set; }
    }
}
