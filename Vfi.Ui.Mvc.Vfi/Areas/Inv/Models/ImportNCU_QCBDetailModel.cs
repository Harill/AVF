using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ImportNCU_QCBDetailModel
    {
        public int DetailId { get; set; }
        public int ImportId { get; set; }
        public int ProductId { get; set; }
        public string ProductImg { get; set; }
        public string UploadDate { get; set; }

        [DataType("Number")]
        public double RequestNumber { get; set; }

        public string RequestNumberString { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Số lượng")]
        [DataType("Number")]
        public double RealNumber { get; set; }

        [DataType("Number")]
        public double Weight { get; set; }

        public double Import { get; set; }
        public string ImportString { get; set; }
        public string Note { get; set; }

        [UIHint("_ProductEditTemplate")]
        [DisplayName("Mã VF")]
        public string ProductCode { get; set; }

        public int ProductInvId { get; set; }

        [UIHint("_ProductCodeInvEditTemplate")]
        public string ProductInvCode { get; set; }
        public string LotNumber { get; set; }
        
        public int ExportDetailId { get; set; }
        public double ExportQuantity { get; set; }
        public double ExportWeight { get; set; }

        public string TransactionCode { get; set; }

        public DateTime ExportDate { get; set; }
        public double ProductWeight { get; set; }
        public double ProductInventory { get; set; }

        public double ProductInventoryG
        {
            get { return ProductInventory * ProductWeight; }
        }

        public double AvailableInventory { get; set; }

        public double AvailableInventoryG
        {
            get { return AvailableInventory * ProductWeight; }
        }

        public string Package { get; set; }
        public bool IsRotateAll { get; set; }
    }
}
