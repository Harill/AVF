using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class Production2TransactionModel
    {
        public long TransactionId { get; set; }
        public string TransactionCode { get; set; }
        public double TotalQuantity { get; set; }
        public double TotalLost { get; set; }
        public double TotalQuantityDefect { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public double Time { get; set; }
        public double OverTime { get; set; }
        public string EoI { get; set; }
        public string EoIName { get; set; }
        public byte Status { get; set; }
        public string StatusName { get; set; }

    }
}