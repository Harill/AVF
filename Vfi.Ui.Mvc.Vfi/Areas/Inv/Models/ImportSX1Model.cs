using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public partial class ImportSX1Model
    {
        public int ImportId { get; set; }
        public Nullable<System.DateTime> ImportDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string TransactionCode { get; set; }

        public string Ca1 { get; set; }
        public string Ca2 { get; set; }
    }
}
