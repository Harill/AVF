using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ExportFormQC_TPDetailModel
    {
        public int DetailId { get; set; }
        public int ExportId { get; set; }
        public int ProductId { get; set; }
        public int Box { get; set; }
        [DataType("Number")]
        public double Weight { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayName("Số lượng")]
        [DataType("Number")]
        public double Number { get; set; }
        public string Note { get; set; }

        [UIHint("_ProductEditTemplate")]
        [DisplayName("Mã VF --- Mã SP Kh")]
        public string ProductCode { get; set; }

    }
}