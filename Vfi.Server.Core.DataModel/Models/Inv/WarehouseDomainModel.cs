using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Inv
{
    public class WarehouseDomainModel: Warehouse
    {
        public virtual new int WarehouseId { get; set; }
        
        public virtual new int? WarehouseTypeId { get; set; }
        
        [DisplayName("Loại kho")]
        public virtual string WarehouseTypeName { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tên kho")]
        public virtual new string WarehouseName { get; set; }
        [DisplayName("Mô tả")]
        public virtual new string Description { get; set; }

        [DisplayName("Thứ tự")]
        public virtual new int Idx { get; set; }
        [DisplayName("Hiển thị trên rpt")]
        public virtual new bool DisplayInReport { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
