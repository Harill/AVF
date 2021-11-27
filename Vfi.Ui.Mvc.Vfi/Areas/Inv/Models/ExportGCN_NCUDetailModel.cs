using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public partial class ExportGCN_NCUDetailModel
    {
        public int DetailId { get; set; }
        public int ExportId { get; set; }
        public int ProductId { get; set; }
        public string ProductImg { get; set; }
        public string UploadDate { get; set; }

        [DataType("Number")]
        public double Weight { get; set; }

        [UIHint("Number")]
        [DataType("Number")]
        public double RequestNumber { get; set; }

        public string RequestNumberString { get; set; }

        [UIHint("Number")]
        [Required(ErrorMessage = "*")]
        [DisplayName("Số lượng")]
        [DataType("Number")]
        public double RealNumber { get; set; }

        public string Note { get; set; }

        [UIHint("_ProductEditTemplate")]
        [DisplayName("Mã VF")]
        public string ProductCode { get; set; }

        public int ProductInvId { get; set; }

        [UIHint("_ProductCodeInvEditTemplate")]
        public string ProductInvCode { get; set; }
        public string LotNumber { get; set; }
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

        public int PlatingDetailId { get; set; }
        public string Package { get; set; }
        public bool IsRotateAll { get; set; }
        public int GroupIndex { get; set; }
    }
}
