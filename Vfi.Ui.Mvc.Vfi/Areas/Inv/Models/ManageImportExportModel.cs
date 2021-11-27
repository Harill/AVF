using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ManageImportExportModel
    {
        public int FormType { get; set; }

        public long TransactionId { get; set; }
        public string TransactionCode { get; set; }
        //public string WarehouseIssueName { get; set; }
        //public string WarehouseReceiptName { get; set; }
        public double TotalQuality { get; set; }

        public string ModifiedUser { get; set; }

        public DateTime? ModidifiedDate { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string Note { get; set; }

        public string Status { get; set; }

    }
}