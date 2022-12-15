
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.Models.Purchasing;

namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models
{
    public class ShipMethodModel {
        public int ShipMethodId { get; set; }

        [DisplayName("Tên loại vận chuyễn")]
        [Required(ErrorMessage = "*")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public string Name { get; set; }

        [DisplayName("Phí trần")]
        [DataType("Number4Digit")]
        public double ShipBase { get; set; }
        [DisplayName("Tỉ lệ phí")]
        [DataType("Number4Digit")]
        public double ShipRate { get; set; }

        [DisplayName("Kích hoạt")]
        public bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public DateTime ModifiedDate { get; set; }

        public double UnitWeight { get; set; }
        public double ShipPrice { get; set; }
    }
}