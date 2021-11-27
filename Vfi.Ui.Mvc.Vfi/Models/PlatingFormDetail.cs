using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class PlatingFormDetail
    {
        public PlatingFormDetail()
        {
            this.ExportGCN_NCUDetail = new List<ExportGCN_NCUDetail>();
        }

        public int DetailId { get; set; }
        public int FormId { get; set; }
        public int ProductId { get; set; }
        public string PlatingCode { get; set; }
        public string Thickness { get; set; }
        public string SaltSprayTime { get; set; }
        public string SpecialRequest { get; set; }
        public string Sample { get; set; }
        public string TestingEquipment { get; set; }
        public string Unit { get; set; }
        public double QuantityRequirement { get; set; }
        public Nullable<System.DateTime> ExportDateRequirement { get; set; }
        public Nullable<System.DateTime> ImportDateRequirement { get; set; }
        public double UnitPrice { get; set; }
        public string Note { get; set; }
        public virtual ICollection<ExportGCN_NCUDetail> ExportGCN_NCUDetail { get; set; }
        public virtual Product Product { get; set; }
        public virtual PlatingForm PlatingForm { get; set; }
    }
}
