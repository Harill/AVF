using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MethodType
    {
        public MethodType()
        {
            this.Methods = new List<Method>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Method> Methods { get; set; }
    }
}
