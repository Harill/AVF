using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class CncFormModel
    {
        public int ImportId { get; set; }
        public System.DateTime ImportDate { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string TransactionCode { get; set; }
        public string Shift1Name { get; set; }
        public string Shift2Name { get; set; }

    }
}