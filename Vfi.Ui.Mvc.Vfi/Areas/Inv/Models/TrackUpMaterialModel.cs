using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class TrackUpMaterialModel
    {
        public int DetailId { get; set; }
        public int TrackId { get; set; }
        public double TrackProductRate { get; set; }
        public double ProductRate { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int MaterialInvId { get; set; }
        public int MaterialId { get; set; }
        public string MaterialCode { get; set; }
        [UIHint("_MaterialInvCodeTemplate")]
        public string MaterialInvCode { get; set; }
        public double MaterialInv { get; set; }
        public double MaterialInvOnMachine { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int MaxAssign { get; set; }
        public string Note { get; set; }
    }
}