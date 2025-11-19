using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class ProductHistoryModel {
        public int HistoryId { get; set; }
        [UIHint("_DateTemplateNullable")]
        public DateTime? HistoryDate { get; set; }
        public string CodeNumber { get; set; }
        public string Before { get; set; }
        public string After { get; set; }
        [UIHint("_UploadProductHistoryImage")]
        public string RefImage { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string UploadDate { get { return ModifiedDate.ToString("yyyyMMddhhmmss"); } }
        public int ProductId { get; set; }
    }
}