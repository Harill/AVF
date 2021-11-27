using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Inv
{
    public class TransactionDomainModel: Transaction
    {
        public virtual new long TransactionId { get; set; }

        public virtual new long? StockOrderId { get; set; }
        [DisplayName("Mã lệnh")]
        public virtual string StockOrderCode { get; set; }
        
        [DisplayName("Kho xuất")]
        public virtual new int? WarehouseIssueId { get; set; }
        [DisplayName("Kho xuất")]
        public virtual string WarehouseIssueName { get; set; }
        [DisplayName("Kho nhập")]
        public virtual new int? WarehouseReceiptId { get; set; }
        [DisplayName("Kho nhập")]
        public virtual string WarehouseReceiptName { get; set; }

        [DisplayName("Mã giao dịch")]
        public virtual new string TransactionCode { get; set; }

        [DisplayName("Xuất ? Nhập")]
        public virtual new string EoI { get; set; }
        [DisplayName("Xuất ? Nhập")]
        public virtual string EoIName { get; set; }

        [DisplayName("Nliệu ? Tphẩm")]
        public virtual new bool MoP { get; set; }

        [DisplayName("Người tạo")]
        [DataType(DataType.Date)]
        public virtual new string CreatedUser { get; set; }
        
        [DisplayName("Ngày")]
        [DataType(DataType.Date)]
        public virtual new DateTime CreatedDate { get; set; }

        [DisplayName("Trạng thái")]
        public virtual new byte Status { get; set; }
        [DisplayName("Trạng thái")]
        public virtual string StatusName { get; set; }

        public virtual new bool IsApprove { get; set; }
        public virtual new string LotNumber { get; set; }

        [DisplayName("Mô tả")]
        public virtual string Description { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime ModifiedDate { get; set; }

        [DisplayName("Tổng số lượng(cây)")]
        public new double TotalQuality { get; set; }
        [DisplayName("Tổng số lượng(Kg)")]
        public new double TotalQualityKg { get; set; }
        public string SpecialNote { get; set; }

        public int AlertColor { get; set; }

        public int PurchasingSignatureType { get; set; }
    }
}
