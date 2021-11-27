using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production
{
    public class ProductChangeModel
    {
        public int ChangeId { get; set; }
        public int ProductId { get; set; }
        public string OldProductCode { get; set; }
        public string NewProductCode { get; set; }
        public double NewPrice { get;set;}
        public double OldPrice { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}