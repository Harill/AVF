using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {

    public class DefectTransactionModel {
        public long TransactionId { get; set; }
        public DateTime CreateDate { get; set; }
        public string TransactionCode { get; set; }
        public byte Status { get; set; }
        public string StatusName { get; set; }

        public long ImportTransactionId { get; set; }
        public string ImportWarehouseName { get; set; }
        public byte EoI { get; set; }

        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }

        public double Quantity { get; set; }
        public double QuantityKg { get; set; }
    }
}