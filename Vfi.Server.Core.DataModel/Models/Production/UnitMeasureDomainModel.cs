using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Production
{
    [Serializable]
    public class UnitMeasureDomainModel: UnitMeasure
    {
        [DisplayName("Mã đơn vị tính")]
        [Required(ErrorMessage = "*")]
        [StringLength(3, ErrorMessage = "* <= 3 ký tự.")]
        public virtual new string UnitMeasureCode { get; set; }

        [DisplayName("Đơn vị tính")]
        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public virtual new string UnitMeasureName { get; set; }

        [DisplayName("Đơn vị tính")]
        public virtual string UnitMeasureCodeName { get { return UnitMeasureCode + " -- " + UnitMeasureName; } }

        //[DisplayName("Kích hoạt")]
        //public virtual new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public virtual new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public virtual new DateTime? ModifiedDate { get; set; }
    }
}
