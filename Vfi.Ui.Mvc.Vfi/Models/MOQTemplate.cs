using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MOQTemplate
    {
        public int TemplateId { get; set; }
        public int FromQuantity { get; set; }
        public int ToQuantity { get; set; }
        public double FactorDefault { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}
