using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class MachineLogModel
    {
        public string MachineName { get; set; }
        public string TypeName { get; set; }

        [UIHint("_DateTemplate")]
        public new DateTime ModifiedDate { get; set; }
        [UIHint("_DateTemplate")]
        public new DateTime DateLog { get; set; }

        public int DiaryId { get; set; }
        public Nullable<int> MachineId { get; set; }
        public string ModifiedUser { get; set; }
        public string Note { get; set; }
        public Nullable<int> Type { get; set; }
    }
}