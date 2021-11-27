using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class MachineErrorCauseModel
    {
        public int Index { get; set; }
        public int ErrorCauseId { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string StateCode { get; set; }

    }
}