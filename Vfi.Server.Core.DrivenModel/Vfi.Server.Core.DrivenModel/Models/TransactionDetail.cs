using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class TransactionDetail
    {
        public long TransactionDetailId { get; set; }
        public Nullable<long> TransactionId { get; set; }
        public Nullable<int> ReferenceId { get; set; }
        public bool MoP { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> QuantityKg { get; set; }
        public Nullable<double> Price { get; set; }
        public string UnitMeasure { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual Material Material { get; set; }
        public virtual Product Product { get; set; }
    }
}
