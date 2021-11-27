using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    [NotMapped]
    public class MaterialUseInShiftModel : MaterialUseInShift
    {
        public string StatusName { get; set; }
        public string TypeName { get; set; }
        public string ShiftName { get; set; }
        public string CodeName { get; set; }
    }
}