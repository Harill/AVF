using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductHistory
    {
        public int HistoryId { get; set; }
        public System.DateTime HistoryDate { get; set; }
        public string CodeNumber { get; set; }
        public string Before { get; set; }
        public string After { get; set; }
        public string RefImage { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
