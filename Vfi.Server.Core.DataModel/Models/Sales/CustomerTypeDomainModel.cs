using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Sales
{
    public class CustomerTypeDomainModel: CustomerType
    {
        public virtual new int CustomerTypeId { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Loại khách hàng")]
        [StringLength(150, ErrorMessage = "* < 150 ký tự")]
        public virtual new string CustomerTypeName { get; set; }

        [DisplayName("Ghi chú")]
        [DataType(DataType.MultilineText)]
        public virtual new string Note { get; set; }

        [DisplayName("Kích hoạt")]
        public virtual new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public virtual new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public virtual new DateTime? ModifiedDate { get; set; }
    }
}
