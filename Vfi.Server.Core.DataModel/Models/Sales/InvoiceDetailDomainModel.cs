using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Sales
{
    public class InvoiceDetailDomainModel: InvoiceDetail
    {
        public virtual new long InvoiceDetailId { get; set; }
        public virtual new long? InvoiceId { get; set; }

        public virtual new int? ProductId { get; set; }
        [DisplayName("Mã sản phẩm")]
        public virtual string ProductCode { get; set; }
        [DisplayName("Tên sản phẩm")]
        public virtual string ProductName { get; set; }
        [DisplayName("Sản phẩm")]
        public virtual string ProductCodeName{get { return ProductCode + " -- " + ProductName; } set { ProductCode = value; }}
        
        
        [DataType("Number")]
        public virtual new int? ProductDespatchNoteId { get; set; }
        [DataType("Number")]
        public virtual new double? ProductLength { get; set; }
        [DataType("Number")]
        public virtual new int? Bundle { get; set; }
        [DataType("Number")]
        public virtual new int? Piece { get; set; }

        [DataType("Number")]
        public virtual new double? Weight { get; set; }
        [DataType("Number")]
        public virtual new double? Price { get; set; }
        [DataType("Number")]
        public virtual new double? Amount { get; set; }
        [DataType("Number")]
        public virtual new double? VatAmount { get; set; }
        [DataType("Number")]
        public virtual new double? TotalAmount { get; set; }
        [DataType("Number")]
        public virtual new int? RemainedBundle { get; set; }
        [DataType("Number")]
        public virtual new double? RemainedWeight { get; set; }
        
        public virtual new int? RemainedPiece { get; set; }
        
        [DisplayName("Ghi chú")]
        public virtual new string Note { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
