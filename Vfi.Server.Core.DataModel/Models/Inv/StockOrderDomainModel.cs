using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Inv
{
    public class StockOrderDomainModel: StockOrder
    {
        public virtual new long StockOrderId { get; set; }

        [DisplayName("Kho xuất")]
        public virtual new int? WarehouseIssueId { get; set; }
        [DisplayName("Kho xuất")]
        public virtual string WarehouseIssueName { get; set; }

        [DisplayName("Kho nhập")]
        public virtual new int? WarehouseReceiptId { get; set; }
        [DisplayName("Kho nhập")]
        public virtual string WarehouseReceiptName { get; set; }
        
        public virtual new int StockOrderTypeId { get; set; }
        [DisplayName("Loại lệnh")]
        public virtual string StockOrderTypeName { get; set; }

        [DisplayName("Mã lệnh")]
        public virtual new string StockOrderCode { get; set; }

        [DisplayName("Xuất ? Nhập")]
        public virtual new string EoI { get; set; }
        [DisplayName("Xuất ? Nhập")]
        public virtual string EoIName { get; set; }

        [DisplayName("Nliệu ? Tphẩm")]
        public virtual new bool MoP { get; set; }
        
        [DisplayName("Trạng thái")]
        public virtual new byte Status { get; set; }
        [DisplayName("Trạng thái")]
        public virtual string StatusName { get; set; }

        [DisplayName("Người tạo")]
        [DataType(DataType.Date)]
        public virtual new string CreatedUser { get; set; }
        [DisplayName("Ngày tạo")]
        [DataType(DataType.Date)]
        public virtual new DateTime? CreatedDate { get; set; }
        
        public virtual new bool IsApprove { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
