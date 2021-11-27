using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ImportWorkpieceModel
    {
        public int ImportId { get; set; }
        public Nullable<int> ImportSx1Id { get; set; }
        public Nullable<long> TransactionId { get; set; }
        public Nullable<System.DateTime> ImportDate { get; set; }
        public string ModifiedUser { get; set; }
    }
    public class ImportWorkpieceDetailModel
    {
        public int DetailId { get; set; }
        public int ImportId { get; set; }
        public string IdentityCode { get; set; }
        [UIHint("_WorkpieceMaterialEditTemplate")]
        public string MaterialTypeName { get; set; }
        [DataType("NumberAsDouble")]
        public double Weight { get; set; }
        public string Note { get; set; }
    }
}