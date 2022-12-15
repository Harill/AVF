using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models {
    public class MOQTemplateModel {
        public int TemplateId { get; set; }
        [DataType("Integer")]
        public int FromQuantity { get; set; }
        [DataType("Integer")]
        public int ToQuantity { get; set; }
        [DataType("Number2Digit")]
        public double FactorDefault { get; set; }
        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }

        public double QuotePrice { get; set; }
        public double MOQQuotePrice { get; set; }
    }
}