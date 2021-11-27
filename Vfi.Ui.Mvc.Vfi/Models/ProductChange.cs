using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductChange
    {
        public int ChangeId { get; set; }
        public int ProductId { get; set; }
        public string OldProductCode { get; set; }
        public string NewProductCode { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<double> OldPrice { get; set; }
        public Nullable<double> NewPrice { get; set; }
        public virtual Product Product { get; set; }
    }
}
