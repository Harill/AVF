using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Purchasing
{
    public class ShipMethodDomainModel: ShipMethod
    {
        public new int ShipMethodId { get; set; }

        [DisplayName("Tên loại vận chuyễn")]
        [Required(ErrorMessage = "*")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public new string Name { get; set; }

        [DisplayName("Phí trần")]
        [DataType("Number")]
        public new double? ShipBase { get; set; }
        [DisplayName("Tỉ lệ phí")]
        [DataType("Number")]
        public new double? ShipRate { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
