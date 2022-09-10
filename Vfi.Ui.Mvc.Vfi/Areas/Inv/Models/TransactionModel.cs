
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.Models.Inv;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class TransactionModel
    {
        public new virtual long TransactionId { get; set; }

        public new virtual long? StockOrderId { get; set; }

        [DisplayName("Mã lệnh")]
        public virtual string StockOrderCode { get; set; }

        [DisplayName("Kho xuất")]
        public new virtual int? WarehouseIssueId { get; set; }

        [DisplayName("Kho xuất")]
        public virtual string WarehouseIssueName { get; set; }

        [DisplayName("Kho nhập")]
        public new virtual int? WarehouseReceiptId { get; set; }

        [DisplayName("Kho nhập")]
        public virtual string WarehouseReceiptName { get; set; }

        [DisplayName("Mã giao dịch")]
        public new virtual string TransactionCode { get; set; }

        [DisplayName("Xuất ? Nhập")]
        public new virtual string EoI { get; set; }

        [DisplayName("Xuất ? Nhập")]
        public virtual string EoIName { get; set; }

        [DisplayName("Nliệu ? Tphẩm")]
        public new virtual bool MoP { get; set; }

        [DisplayName("Người tạo")]
        [DataType(DataType.Date)]
        public new virtual string CreatedUser { get; set; }

        [DisplayName("Ngày")]
        //[DataType(DataType.Date)]
        [UIHint("_DateTemplate")]
        public new virtual DateTime CreatedDate { get; set; }

        [DisplayName("Trạng thái")]
        public new virtual byte Status { get; set; }

        [DisplayName("Tình trạng")]
        public virtual string StatusName { get; set; }

        public bool CanApprove { get; set; }
        public new virtual string LotNumber { get; set; }

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

        public new double ExchangeRate { get; set; }

        public int InvManager { get; set; }

        public int SpecialFormType { get; set; }

        public bool IsInternal { get; set; }
        public bool Highlight { get; set; }
    }


}