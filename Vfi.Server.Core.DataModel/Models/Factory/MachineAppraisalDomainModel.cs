using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Factory
{
    public class MachineAppraisalDomainModel: MachineAppraisal
    {
        public virtual new long AppraisalId { get; set; }

        // warehosue
        public virtual new int? WarehouseId { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayName("Kho")]
        public virtual string WarehouseName { get; set; }
        // warehosue

        // machine
        public virtual new int? MachineId { get; set; }
        [DisplayName("Tên máy")]
        public virtual string MachineName { get; set; }
        // machine
        
        // product
        public virtual new int? ProductId { get; set; }
        [DisplayName("Mã thành phẩm")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public string ProductCode { get; set; }

        [DisplayName("Tên thành phẩm")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public string ProductName { get; set; }

        [DisplayName("Thành phẩm")]
        public virtual string ProductCodeName { get { return ProductCode + " -- " + ProductName; } set { ProductCode = value; } }
        // product

        [Required(ErrorMessage = "*")]
        [DisplayName("Tgian ước lượng")]
        public virtual new int? AppraisalTime { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
