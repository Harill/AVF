using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class ProcessClassifiedModel {
        public int ClassifiedId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FullDescription { get { return Name + "-" + Description; } }
        [DataType("Number4Digit")]
        public double SalesFactor { get; set; }
        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}