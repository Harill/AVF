using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public partial class PrintImportNCU_QCBModel
    {
       // public int DetailId { get; set; }
       // public int ImportId { get; set; }
        // public int ProductId { get; set; }
        public double RequestNumber { get; set; }
        public object RequestNumberString { get; set; }
        public double RealNumber { get; set; }
        public double Weight { get; set; }
        public string WeightString { get; set; }
        public string Note { get; set; }

        public string ProductCode { get; set; }
        public string TransactionCode { get; set; }
        public string ProviderName { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<int> BoxNumber { get; set; }
        public Nullable<System.DateTime> ImportDate { get; set; }

        public string ImportDateString { get; set; }
        public string ModifiedDateString { get; set; }
        public string StatusName { get; set; }
        public string CustomerCode { get; set; }
        public string Package { get; set; }

        public int PurchasingSignature { get; set; }
    }
}
