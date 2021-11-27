using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ExportGCN_NCUDetail
    {
        public ExportGCN_NCUDetail()
        {
            this.ImportNCU_QCBDetail = new List<ImportNCU_QCBDetail>();
        }

        public int DetailId { get; set; }
        public int ExportId { get; set; }
        public int ProductId { get; set; }
        public Nullable<double> Weight { get; set; }
        public double RequestNumber { get; set; }
        public double RealNumber { get; set; }
        public string Note { get; set; }
        public Nullable<int> PlatingDetailId { get; set; }
        public string Package { get; set; }
        public Nullable<int> ProductInvId { get; set; }
        public Nullable<long> TransactionDetailId { get; set; }
        public virtual ExportGCN_NCU ExportGCN_NCU { get; set; }
        public virtual PlatingFormDetail PlatingFormDetail { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductInventory ProductInventory { get; set; }
        public virtual TransactionDetail TransactionDetail { get; set; }
        public virtual ICollection<ImportNCU_QCBDetail> ImportNCU_QCBDetail { get; set; }
    }
}
