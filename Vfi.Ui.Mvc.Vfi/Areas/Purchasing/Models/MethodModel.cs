using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models
{
    public class MethodModel
    {
        public int MethodId { get; set; }
        public string MethodName { get; set; }
        public string MethodName_EN { get; set; }
        public int TypeId { get; set; }
        [UIHint("_MethodTypeEditTemplate")]
        public string TypeName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public bool SaleMethod { get; set; }
        public bool BuyMethod { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}