using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Inv
{
    public class WarehouseTypeDomainModel: WarehouseType
    {
        public virtual new int WarehouseTypeId { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tên loại kho")]
        public virtual new string WarehouseTypeName { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
