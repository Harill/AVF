using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class CustomerType
    {
        public CustomerType()
        {
            Customers = new List<Customer>();
        }

        public int CustomerTypeId { get; set; }
        public string CustomerTypeName { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
