using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class MachineStateModel
    {
        public int Index { get; set; }
        public int StateId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        [DataType("NumberAsInt")]
        public int Timing { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int WarrningPoint { get; set; }
        public string WarrningColor { get; set; }
        public string FontColor { get; set; }
        public string StateCode { get; set; }
        public int EstimateTime { get; set; }
        public bool IsSetProduct { get; set; }

        public string NameEN { get; set; }
    }
}