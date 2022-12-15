using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production {
    public class MaterialQuoteBaseDetailModel {
        public int DetailId { get; set; }
        public int MaterialQuoteBaseId { get; set; }
        [DataType("Number2Digit")]
        public double FromOutDiameter { get; set; }
        [DataType("Number2Digit")]
        public double ToOutDiameter { get; set; }
        [DataType("Number2Digit")]
        public double InDiameter { get; set; }
        [DataType("Number2Digit")]
        public double Value { get; set; }
        public double Price { get; set; }
    }
}