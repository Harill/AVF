
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.Models.Production;

namespace Vfi.Ui.Mvc.Vfi.Models.Production
{
    public class UnitMeasureModel
    {
        public int UnitId { get; set; }
        [DisplayName("Mã đơn vị tính")]
        [Required(ErrorMessage = "*")]
        public virtual string UnitMeasureCode { get; set; }

        [DisplayName("Đơn vị tính")]
        [Required(ErrorMessage = "*")]
        public virtual string UnitMeasureName { get; set; }

        [DisplayName("Đơn vị tính")]
        public virtual string UnitMeasureCodeName { get { return UnitMeasureCode + " -- " + UnitMeasureName; } }

        //[DisplayName("Kích hoạt")]
        //public virtual new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public virtual string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public virtual DateTime ModifiedDate { get; set; }
        [DisplayName("Xi mạ")]
        public virtual bool IsPlatingUnit { get; set; }
    }
}