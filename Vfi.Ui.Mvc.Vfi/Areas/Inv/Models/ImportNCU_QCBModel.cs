using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public partial class ImportNCU_QCBModel
    {
        public int ImportId { get; set; }
        public string TransactionCode { get; set; }
        public string ProviderName { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<int> BoxNumber { get; set; }
        public Nullable<System.DateTime> ImportDate { get; set; }
        public long TransactionId { get; set; }
        public double TotalNumber { get; set; }
        public double TotalWeight { get; set; }
    }
}
