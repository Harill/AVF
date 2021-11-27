using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Parameter
    {
        public int ParamId { get; set; }
        public string ParamCode { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
