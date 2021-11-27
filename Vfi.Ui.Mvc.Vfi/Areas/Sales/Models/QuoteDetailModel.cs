using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class QuoteDetailModel
    {
        public int DetailId { get; set; }
        public int ProductId { get; set; }
        [UIHint("_ProductCodeNameTemplate")]
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductCustomerCode { get; set; }
        [DataType("Number")]
        public double Diff { get; set; }
        [DataType("Number")]
        public double MaterialPrice { get; set; }
        [DataType("Number")]
        public double MaterialUnitPrice { get; set; }
        public string MaterialDesign { get; set; }
        [DataType("NumberAsShort")]
        public double Quantity { get; set; }
        public string Note { get; set; }

        public int QuoteId { get; set; }

        public string Dimension { get; set; }
        public double FinalPrice { get; set; }

        public string ProcessingTypeDesign { get; set; }
        public double ProcessingPrice { get; set; }
        public double ProductWeight { get; set; }
    }
}