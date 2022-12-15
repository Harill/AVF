using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class ProductionProductivityQuoteBaseModel {

        public int BaseId { get; set; }
        public int ProductId { get; set; }
        [DataType("Int")]
        public int Idx { get; set; }
        public string Name { get; set; }
        [DataType("Int")]
        public int Round { get; set; }
        [DataType("Number1Digit")]
        public double L { get; set; }
        [DataType("Number3Digit")]
        public double F { get; set; }
        public double Time { get; set; }
        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public bool IsCalculateLock { get; set; }
    }
}