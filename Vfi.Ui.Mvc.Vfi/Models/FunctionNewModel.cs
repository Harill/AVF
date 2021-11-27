using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public class FunctionNewModel
    {
        public virtual long FunctionId { get; set; }

        public virtual int Creation { get; set; }

        public virtual int Modification { get; set; }

        public virtual int Deletion { get; set; }

        public virtual int Execution { get; set; }

        public virtual string FunctionCode { get; set; }

        public virtual string FunctionName { get; set; }

        public virtual string Description { get; set; }

        public virtual bool Active { get; set; }

        public virtual DateTime ModifiedDate { get; set; }

    }
}