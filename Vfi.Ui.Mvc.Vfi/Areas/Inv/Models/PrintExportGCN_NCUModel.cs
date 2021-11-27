using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public partial class PrintExportGCN_NCUModel
    {
        public double Weight { get; set; }
        public string WeightString { get; set; }
        public double RequestNumber { get; set; }
        public object RequestNumberString { get; set; }
        public double RealNumber { get; set; }
        public string Note { get; set; }
        public int ProductId{get;set;}
        public string ProductCode { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<int> BoxNumber { get; set; }
        public Nullable<int> BlockNumber { get; set; }
        public string TransactionCode { get; set; }
        public string ProviderName { get; set; }
        public Nullable<System.DateTime> ExportDate { get; set; }


        public string StatusName { get; set; }
        public string ModifiedDateString { get; set; }
        public string ExportDateString { get; set; }
        public string CustomerCode { get; set; }
        public string Package { get; set; }
        public int PackageNumber { get; set; }
        public int PlatingDetailId { get; set; }
    }
}
