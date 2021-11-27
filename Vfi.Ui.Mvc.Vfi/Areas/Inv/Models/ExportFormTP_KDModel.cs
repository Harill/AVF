using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ExportFormTP_KDModel
    {
        //export form
        public int ExportFormId { get; set; }
        public int CustomerId { get; set; }
        public string Transporter { get; set; }
        public string CompanyTransporter { get; set; }
        public string CarNumber { get; set; }
        public DateTime DateTransporter { get; set; }
        public DateTime DateCreate { get; set; }
        public long TransactionId { get; set; }
        public string TransactionCode { get; set; }
        public virtual Customer Customer { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CustomerCode { get; set; } 
        public double TotalQuality { get; set; }
        public int TotalBox { get; set; }
    }
}