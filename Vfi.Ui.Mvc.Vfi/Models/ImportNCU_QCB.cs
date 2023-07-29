using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ImportNCU_QCB
    {
        public ImportNCU_QCB()
        {
            this.ImportNCU_QCBDetail = new List<ImportNCU_QCBDetail>();
        }

        public int ImportId { get; set; }
        public string TransactionCode { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.DateTime ImportDate { get; set; }
        public int BoxNumber { get; set; }
        public string ProviderName { get; set; }
        public Nullable<int> PlatingFormId { get; set; }
        public Nullable<long> TransactionId { get; set; }
        public Nullable<bool> IsWorkOrder { get; set; }
        public byte PurchasingSignature { get; set; }
        public virtual PlatingForm PlatingForm { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual ICollection<ImportNCU_QCBDetail> ImportNCU_QCBDetail { get; set; }
    }
}
