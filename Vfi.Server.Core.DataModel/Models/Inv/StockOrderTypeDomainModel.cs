using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Inv
{
    public class StockOrderTypeDomainModel: StockOrderType
    {
        public virtual new int StockOrderTypeId { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tên loại lệnh")]
        public virtual new string StockOrderTypeName { get; set; }

        [DisplayName("Xuất ? Nhập")]
        public virtual new bool EoI { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
