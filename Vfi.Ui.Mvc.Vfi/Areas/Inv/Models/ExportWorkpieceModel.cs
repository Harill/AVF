using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ExportWorkpieceModel
    {

        public int ExportId { get; set; }
        public DateTime ExportDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
    public class ExportWorkpieceDetailModel
    {

        public int DetailId { get; set; }
        public int ExportId { get; set; }
        public string IdentityCode { get; set; }
        [UIHint("_WorkpieceMaterialEditTemplate")]
        public string MaterialTypeName { get; set; }
        [DataType("Number2")]
        public double Weight { get; set; }
        [DataType("Number")]
        public double UnitPrice { get; set; }
        public string Note { get; set; }
    }
}