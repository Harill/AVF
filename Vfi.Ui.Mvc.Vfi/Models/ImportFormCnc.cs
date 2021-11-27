using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ImportFormCnc
    {
        public ImportFormCnc()
        {
            this.ImportFormCncDetails = new List<ImportFormCncDetail>();
        }

        public int ImportId { get; set; }
        public System.DateTime ImportDate { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string TransactionCode { get; set; }
        public string Shift1Name { get; set; }
        public string Shift2Name { get; set; }
        public System.DateTime MaterialUseDate { get; set; }
        public virtual ICollection<ImportFormCncDetail> ImportFormCncDetails { get; set; }
    }
}
