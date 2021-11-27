using System;
using System.ComponentModel;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Sales
{
    public class InvoiceDomainModel: Invoice
    {
        public virtual new long InvoiceId { get; set; }
        
        public virtual new int CustomerId { get; set; }

        [DisplayName("Khách hàng")]
        public virtual string CustomerCode { get; set; }
        [DisplayName("Khách hàng")]
        public virtual string CustomerName { get; set; }
        [DisplayName("Khách hàng")]
        public virtual string CustomerCodeName { get { return CustomerCode + " -- " + CustomerName; } set { CustomerCode = value; } }

        public virtual new int? PriceListId { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
