using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class SectionProcessDetailModel {
        public int DetailId { get; set; }
        public int SectionId { get; set; }
        [UIHint("_SectionEditByProductTemplate")]
        public string SectionName { get; set; }
        public int ProcessId { get; set; }
        public int ProductId { get; set; }
        [DataType("Int")]
        public int DetailIndex { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}