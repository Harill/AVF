using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Sales
{
    public class TimeLineDomainModel: TimeLine
    {
        public virtual new int TimeLineId { get; set; }

        public virtual new long? SalesOrderDetailId { get; set; }
        
        public virtual new int? WarehouseId { get; set; }
        [DisplayName("Tên kho")]
        public virtual string WarehouseName { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Thời gian")]
        [DataType("Number")]
        public virtual new int? Times { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Thời gian thật")]
        [DataType("Number")]
        public virtual new int? RealTimes { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Hiệu năng")]
        [DataType("Number")]
        public virtual new double? Performance { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Ngày bắt đầu")]
        [DataType("Number")]
        public virtual new DateTime? StartDay { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Ngày hoàn tất")]
        [DataType("Number")]
        public virtual new DateTime? FinishedDay { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tg làm việc")]
        [DataType("Number")]
        public virtual new int? WorkingHours { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
