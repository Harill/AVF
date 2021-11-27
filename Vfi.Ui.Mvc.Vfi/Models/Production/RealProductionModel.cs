using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production
{
    public class RealProductionModel
    {
        public int RealId { get; set; }
        public int ProductId { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public double RealProductivity { get; set; }
        public int RealProductRate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}