using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class PlatingForm
    {
        public PlatingForm()
        {
            this.ExportGCN_NCU = new List<ExportGCN_NCU>();
            this.ImportNCU_QCB = new List<ImportNCU_QCB>();
            this.PlatingFormDetails = new List<PlatingFormDetail>();
        }

        public int FormId { get; set; }
        public int VendorId { get; set; }
        public string PlatingFormNumber { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public byte Status { get; set; }
        public string CurrencyCode { get; set; }
        public int ExchangeRate { get; set; }
        public string Note { get; set; }
        public int PlatingType { get; set; }
        public virtual ICollection<ExportGCN_NCU> ExportGCN_NCU { get; set; }
        public virtual ICollection<ImportNCU_QCB> ImportNCU_QCB { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<PlatingFormDetail> PlatingFormDetails { get; set; }
    }
}
