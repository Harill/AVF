using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ImportSX1DetailModel
    {

        public int DetailId { get; set; }
        public int ImportSX1Id { get; set; }
        public string Shift1 { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayName("Số lượng")]
        [DataType("Number")]
        public double Number1 { get; set; }
        public string Shift2 { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayName("Số lượng")]
        [DataType("Number")]
        public double Number2 { get; set; }
        public int ProductId { get; set; }
        public string Machine { get; set; }

        [DataType("Number")]
        public double DefectProduct1 { get; set; }
        [DataType("Number")]
        public double DefectProduct2 { get; set; }

        [UIHint("_ProductEditTemplate")]
        [DisplayName("Mã VF")]
        public string ProductCode { get; set; }
    }
}